using WildSandbox.Common;

namespace WildSandbox.MessageEngine.Compiler
{
  delegate object ReadFieldsFromDelegate(BitPackReader reader);

  class CompiledObjectReader
  {
    public ReadFieldsFromDelegate ReadFieldsFrom { get; }

    public CompiledObjectReader(ReadFieldsFromDelegate readDelegate)
    {
      ReadFieldsFrom = readDelegate;
    }
  }
}
