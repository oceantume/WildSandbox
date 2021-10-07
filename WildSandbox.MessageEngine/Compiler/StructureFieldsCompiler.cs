using System;
using System.Linq;
using System.Linq.Expressions;
using WildSandbox.Common;

namespace WildSandbox.MessageEngine.Compiler
{
  class StructureFieldsCompiler : IFieldsCompiler
  {
    Type MessageType { get;  }
    OrderedFields Fields { get; }

    public StructureFieldsCompiler(Type messageType, OrderedFields fields)
    {
      MessageType = messageType;
      Fields = fields;
    }

    public TDelegate CompileReader<TDelegate>()
    {
      var readerParam = Expression.Parameter(typeof(BitPackReader), "reader");
      var messageVariable = Expression.Variable(MessageType, "message");

      LabelTarget returnTarget = Expression.Label(typeof(object), "return");

      var variables = new ParameterExpression[] { messageVariable };
      var expressions = Fields
        .Select(f => f.GetReaderExpression(readerParam, messageVariable))
        .Prepend(Expression.Assign(messageVariable, Expression.New(MessageType)))
        .Append(Expression.Label(returnTarget, messageVariable));

      var lambda =
        Expression.Lambda<TDelegate>(
          Expression.Block(variables, expressions),
          readerParam);

      return lambda.Compile();
    }

    public TDelegate CompileWriter<TDelegate>()
    {
      var messageParam = Expression.Parameter(typeof(object), "messageAsObject");
      var writerParam = Expression.Parameter(typeof(BitPackWriter), "writer");
      var messageVariable = Expression.Variable(MessageType, "message");

      var variables = new ParameterExpression[] { messageVariable };

      var expressions = Fields
        .Select(f => f.GetWriterExpression(writerParam, messageVariable))
        .Prepend(Expression.Assign(messageVariable, Expression.Convert(messageParam, MessageType)));

      var lambda =
        Expression.Lambda<TDelegate>(
          Expression.Block(variables, expressions),
          writerParam,
          messageParam);

      return lambda.Compile();
    }

    public TDelegate CompileSize<TDelegate>()
    {
      var messageParam = Expression.Parameter(typeof(object), "messageAsObject");
      var positionParam = Expression.Parameter(typeof(long), "position");
      var messageVariable = Expression.Variable(MessageType, "message");
      var totalVariable = Expression.Variable(typeof(long), "total");

      LabelTarget returnTarget = Expression.Label(typeof(long), "return");

      var variables = new ParameterExpression[] { messageVariable, totalVariable };
      var expressions = Fields
        .Select(f => f.GetWriteSizeExpression(totalVariable, messageVariable))
        .Prepend(Expression.Assign(messageVariable, Expression.Convert(messageParam, MessageType)))
        //.Prepend(Expression.Assign(totalVariable, Expression.Constant(0u)))
        .Prepend(Expression.Assign(totalVariable, positionParam))
        .Append(Expression.Label(returnTarget, totalVariable));//Expression.Constant(0u)));

      var lambda =
        Expression.Lambda<TDelegate>(
          Expression.Block(variables, expressions),
          positionParam,
          messageParam);

      return lambda.Compile();
    }
  }
}
