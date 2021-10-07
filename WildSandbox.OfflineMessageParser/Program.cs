using CommandLine;
using WildSandbox.OfflineMessageParser.Parser;

namespace WildSandbox.OfflineMessageParser
{
  class Program
  {
    static void Main(string[] args)
    {
      CommandLine.Parser.Default
        .ParseArguments<Options>(args)
        .WithParsed(RunParser);
    }

    static void RunParser(Options options)
    {
      // "E:/Code/WildStar/Caps/6152_session2mapchange.pcapng"
      // 24000
      // "C:/Program Files/Wireshark/tshark.exe"

      MessageParser.MessageParser parser = new MessageParser.MessageParser(options.Build, options.OutputPath);
      var reader = new TSharkReader(parser.ParsePacket, options.CapturePath, options.Port, options.TSharkPath);
      reader.ReadAllPackets();
    }
  }
}
