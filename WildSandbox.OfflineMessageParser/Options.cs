using CommandLine;

namespace WildSandbox.OfflineMessageParser
{
  class Options
  {
    [Value(0, MetaName = "build", Required = true, HelpText = "The build version that the packets were recorded on.")]
    public int Build { get; set; }

    [Value(1, MetaName = "input capture", Required = true, HelpText = "The path to the packets capture file. Needs to be readable by tshark.")]
    public string CapturePath { get; set; } = "";

    [Option("port", Required = false, Default = 24000, HelpText = "The server port to analyze packets from.")]
    public int Port { get; set; }

    [Option("output", Required = false, Default = "./", HelpText = "The output directory or file where the parser results will be sent.")]
    public string? OutputPath { get; set; }

    [Option("tshark", Required = false, Default = "tshark", HelpText = "The path to the tshark executable.")]
    public string? TSharkPath { get; set; }
  }
}
