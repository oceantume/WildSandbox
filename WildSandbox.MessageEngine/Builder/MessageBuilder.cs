using System;
using WildSandbox.Common.Messages;
using WildSandbox.MessageEngine.Compiler;

namespace WildSandbox.MessageEngine.Builder
{
  class MessageBuilder : IMessageBuilder
  {
    ICompiledTypesCache Cache { get; set; }
    IFieldsCompiler? Compiler { get; set; }

    public MessageBuilder(ICompiledTypesCache cache)
    {
      Cache = cache;
    }

    public IFieldsCompiler? GetFieldsCompiler()
    {
      return Compiler;
    }

    public IFieldsBuilder<TMsg> FieldsOf<TMsg>()
    {
      var fields = new OrderedFields();
      Compiler = new StructureFieldsCompiler(typeof(TMsg), fields);
      return new FieldsBuilder<TMsg>(Cache, fields);
    }

    public void WithNoFields()
    {
      var fields = new OrderedFields();
      Compiler = new StructureFieldsCompiler(typeof(object), fields);
    }
  }
}
