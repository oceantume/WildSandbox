using System;
using System.Diagnostics;
using System.IO;
using WildSandbox.Common;

namespace WildSandbox.OfflineMessageParser.Parser
{
  class TSharkReader
  {
    private const int PACKET_SIZE_BITS = 0x18;
    private const int PACKET_SIZE_BYTES = (PACKET_SIZE_BITS + 7) / 8;
    private const int PACKET_ID_BITS = 0xB;
    private const int PACKET_HEADER_BITS = PACKET_SIZE_BITS + PACKET_ID_BITS;
    private const int PACKET_HEADER_BYTES = (PACKET_HEADER_BITS + 7) / 8;

    ProcessStartInfo StartInfo { get; set; }
    string ServerPort { get; }
    PacketHandler Handler { get; }

    public delegate void PacketHandler(Packet packet);

    public TSharkReader(PacketHandler handler, string pcapPath, int serverPort, string? tsharkPath = null)
    {
      Handler = handler;
      ServerPort = serverPort.ToString();
      StartInfo = new ProcessStartInfo
      {
        FileName = tsharkPath ?? "tshark",
        Arguments = $"-r \"{pcapPath}\" -Y \"(tcp.port == {serverPort}) && data\" -T fields -e tcp.srcport -e tcp.dstport -e tcp.payload",
        UseShellExecute = false,
        RedirectStandardOutput = true
      };
    }

    public void ReadAllPackets()
    {
      var process = Process.Start(StartInfo);

      if (process == null)
        throw new ApplicationException("Failed to start tshark.");

      var serverStateMachine = new PacketsStateMachine(Handler, PacketSource.Server);
      var clientStateMachine = new PacketsStateMachine(Handler, PacketSource.Client);

      while (true)
      {
        string? line = process.StandardOutput.ReadLine();

        if (line == null)
          return; // end of stream

        var parts = line.Split("\t");
        var srcPort = parts[0];
        var dstPort = parts[1];
        var dataHex = parts[2];

        if (srcPort == ServerPort)
        {
          // Server packet
          //Console.WriteLine($"Server packet (len:{dataHex.Length / 2})");
          serverStateMachine.ReceiveData(GetBufferFromHexString(dataHex));
        }
        else if (dstPort == ServerPort)
        {
          // Client packet
          //Console.WriteLine($"Client packet (len:{dataHex.Length / 2})");
          clientStateMachine.ReceiveData(GetBufferFromHexString(dataHex));
        }
        else
        {
          throw new ApplicationException($"Unexpected ports in stream (src: {srcPort} dst: {dstPort}).");
        }
      }
    }

    class PacketsStateMachine
    {
      PacketHandler Handler { get; }
      PacketSource Source { get; }

      MemoryStream Stream { get; set; }
      BitPackReader Reader { get; set; }
      //Packet? CurrentPacket { get; set; }
      int CurrentPacketSize { get; set; }

      public PacketsStateMachine(PacketHandler handler, PacketSource source = PacketSource.Unknown)
      {
        Stream = new MemoryStream(4095);
        Reader = new BitPackReader(Stream);
        Source = source;
        Handler = handler;
      }

      public void ReceiveData(byte[] data)
      {
        var remaining = data.Length;

        void ReadAvailableBytesUpToTargetSize(int targetSize)
        {
          var countToWrite = Math.Min(targetSize - (int)Stream.Position, remaining);
          Stream.Write(data, data.Length - remaining, countToWrite);
          remaining -= countToWrite;
        }

        while (remaining > 0)
        {
          if (Stream.Position < PACKET_SIZE_BYTES)
          {
            Stream.SetLength(PACKET_SIZE_BYTES);
            ReadAvailableBytesUpToTargetSize(PACKET_SIZE_BYTES);
          }
          else if (Stream.Position < CurrentPacketSize)
          {
            Stream.SetLength(CurrentPacketSize);
            ReadAvailableBytesUpToTargetSize(CurrentPacketSize);
          }
          else
          {
            throw new ApplicationException("Unexpected state.");
          }

          // Received packet size
          if (Stream.Position == PACKET_SIZE_BYTES)
          {
            var reader = new BitPackReader(new MemoryStream(Stream.GetBuffer(), 0, PACKET_SIZE_BYTES, false));
            var size = (int)reader.ReadInteger(PACKET_SIZE_BITS);

            if (size == 0)
            {
              throw new ApplicationException("Invalid size!");
              //ResetStream();
              //continue;
            }

            CurrentPacketSize = size;
            Stream.SetLength(size);
          }
          // Received full packet
          else if (CurrentPacketSize > 0 && Stream.Position == CurrentPacketSize)
          {
            var reader = new BitPackReader(new MemoryStream(Stream.GetBuffer(), 0, CurrentPacketSize, false));
            var size = (int)reader.ReadInteger(PACKET_SIZE_BITS);
            var id = (int)reader.ReadInteger(PACKET_ID_BITS);

            var buf = new byte[Stream.Length];
            Array.Copy(Stream.GetBuffer(), buf, Stream.Length);
            
            Handler(new Packet(CurrentPacketSize, id, buf, reader, Source));

            CurrentPacketSize = -1;
            ResetStream();
          }
        }

      }

      private void ResetStream()
      {
        Stream.Position = 0;
        Stream.SetLength(0);
      }

    }

    static byte[] GetBufferFromHexString(string hexString)
    {
      byte[] buffer = new byte[hexString.Length / 2];
      for (int i = 0; i < hexString.Length; i += 2)
        buffer[i / 2] = Convert.ToByte(hexString.Substring(i, 2), 16);
      return buffer;
    }
  }
}
