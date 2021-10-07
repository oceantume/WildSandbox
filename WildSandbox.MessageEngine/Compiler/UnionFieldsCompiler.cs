using System;

namespace WildSandbox.MessageEngine.Compiler
{
  class UnionFieldsCompiler : IFieldsCompiler
  {
    Type MessageType { get; }
    OrderedFields Fields { get; }

    public UnionFieldsCompiler(Type messageType, OrderedFields fields)
    {
      MessageType = messageType;
      Fields = fields;
    }

    public TDelegate CompileReader<TDelegate>()
    {
      throw new NotImplementedException();
    }

    public TDelegate CompileWriter<TDelegate>()
    {
      throw new NotImplementedException();
    }

    public TDelegate CompileSize<TDelegate>()
    {
      throw new NotImplementedException();
    }
  }
}
