using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using WildSandbox.Common.Messages;
using WildSandbox.OfflineMessageParser.Parser;

namespace WildSandbox.OfflineMessageParser.MessageParser
{
  class MessageParser
  {
    const int PACKET_SIZE_BITS = 0x18;
    const int PACKET_ID_BITS = 0xB;
    const int PACKET_HEADER_BYTES = (PACKET_SIZE_BITS + PACKET_ID_BITS + 7) / 8;

    MessageEngine.IMessageEngine Engine { get; } = MessageEngine.Engine.CreateMessageEngine();
    IReadOnlyDictionary<int, Type> MessageTypes { get; }
    string OutputPath { get; }

    JsonSerializerSettings JsonSettings { get; } = new JsonSerializerSettings
    {
      Formatting = Formatting.Indented,
      NullValueHandling = NullValueHandling.Ignore,
    };

    public MessageParser(int buildNumber, string? outputPath = null)
    {
      MessageTypes = GetMessageTypesFromAssembly(buildNumber);
      Console.WriteLine($"Loaded {MessageTypes.Count} message types.");

      if (outputPath == null || !Path.HasExtension(outputPath))
      {
        string filename = $"packets_{DateTime.Now:yyyy-MM-dd_HH-mm-ss-dd-fff}.json";
        OutputPath = Path.Combine(outputPath ?? "./", filename);
      }
      else
      {
        OutputPath = outputPath;
      }
    }

    private static IReadOnlyDictionary<int, Type> GetMessageTypesFromAssembly(int buildNumber)
    {
      var assemblyName = $"WildSandbox.Messages.Build{buildNumber}";
      return Assembly.Load(assemblyName)
        .GetTypes()
        .Select(t => new { MessageType = t, Attribute = t.GetCustomAttribute<MessageAttribute>() })
        .Where(x => x.Attribute?.Build == buildNumber)
        .ToImmutableDictionary(x => x.Attribute!.Id, x => x.MessageType);
    }

    public void ParsePacket(Packet packet)
    {
      // Ignore ping packets
      if (packet.Id == 0 || packet.Id == 1)
        return;

      // TODO: Handle this better. It could even contain multiple messages.
      if (packet.Id == 0x1D0)
      {
        packet = HandleSubMessage(packet);
      }

      if (!MessageTypes.TryGetValue(packet.Id, out var type))
      {
        Console.WriteLine("No definition for packet 0x{0:X4}", packet.Id);
        return;
      }

      object result = Engine.ReadMessageFrom(packet.Reader, type);
      object output = new
      {
        Id = string.Format("0x{0:X4}", packet.Id),
        Source = packet.Source.ToString(),
        Data = packet.Data,
        DataLength = packet.Data.Length,
        Message = result
      };

      string json = JsonConvert.SerializeObject(output, JsonSettings);

      File.AppendAllText(OutputPath, $"{json}\r\n");

      // TODO: Check if we still have at least a byte to read in stream. If so, we haven't read the full packet.
    }

    private Packet HandleSubMessage(Packet packet)
    {
      packet.Reader.Align();
      var size = (int)packet.Reader.ReadInteger(0x18);
      var id = (int)packet.Reader.ReadInteger(0xB);

      if (size != packet.Size - PACKET_HEADER_BYTES)
      {
        throw new ApplicationException("SubMessage has unexpected size. Can it contain multiple sub messages?");
      }

      return new Packet(size, id, packet.Data.AsSpan(5, size).ToArray(), packet.Reader, packet.Source);
    }
  }
}
