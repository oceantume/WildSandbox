using WildSandbox.Common;

namespace WildSandbox.MessageEngine.Compiler
{
  delegate void WriteFieldsToDelegate(BitPackWriter writer, object message);
  delegate long AddFieldsSizeDelegate(long position, object message);

  class CompiledObjectWriter
  {
    public WriteFieldsToDelegate WriteFieldsTo { get; }
    public AddFieldsSizeDelegate AddFieldsSize { get; }

    public CompiledObjectWriter(WriteFieldsToDelegate writeDelegate, AddFieldsSizeDelegate sizeDelegate)
    {
      WriteFieldsTo = writeDelegate;
      AddFieldsSize = sizeDelegate;
    }
  }
}
