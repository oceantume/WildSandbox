using System;
using System.Linq.Expressions;
using WildSandbox.MessageEngine.Compiler;

namespace WildSandbox.MessageEngine.ValueExpressions
{
  class StructureValueExpressionBuilder : IValueExpressionBuilder
  {
    Type StructureType { get; }
    ICompiledTypesCache TypesCache { get; }

    public StructureValueExpressionBuilder(Type type, ICompiledTypesCache typesCache)
    {
      StructureType = type;
      TypesCache = typesCache;
    }

    public Expression GetReaderExpression(ParameterExpression reader)
    {
      return Expression.Invoke(
        Expression.Constant(
          TypesCache.GetReader(StructureType).ReadFieldsFrom),
        reader);
    }

    public Expression GetWriterExpression(ParameterExpression writer, Expression value)
    {
      return Expression.Invoke(
        Expression.Constant(
          TypesCache.GetWriter(StructureType).WriteFieldsTo),
        writer,
        value);
    }

    public Expression GetWriteSizeExpression(ParameterExpression total, Expression value)
    {
      return Expression.Assign(
        total,
        Expression.Invoke(
          Expression.Constant(
            TypesCache.GetWriter(StructureType).AddFieldsSize),
          total,
          value));
    }
  }
}
