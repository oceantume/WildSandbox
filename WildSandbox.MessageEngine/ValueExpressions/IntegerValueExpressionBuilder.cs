using System;
using System.Linq.Expressions;
using WildSandbox.Common;

namespace WildSandbox.MessageEngine.ValueExpressions
{
  class IntegerValueExpressionBuilder : IValueExpressionBuilder
  {
    public Type Type { get; set; }
    public int Bits { get; set; }

    public IntegerValueExpressionBuilder(Type type, int bits)
    {
      Type = type;
      Bits = bits;
    }

    public Expression GetReaderExpression(ParameterExpression reader)
    {
      var readMethod = typeof(BitPackReader).GetMethod(nameof(BitPackReader.ReadInteger))!;
      var callExpr = Expression.Call(reader, readMethod, Expression.Constant((int)Bits));
      return Expression.Convert(callExpr, Type);
    }

    public Expression GetWriterExpression(ParameterExpression writer, Expression value)
    {
      var writeMethod = typeof(BitPackWriter).GetMethod(nameof(BitPackWriter.WriteInteger))!;
      return Expression.Call(writer, writeMethod, Expression.Convert(value, typeof(long)), Expression.Constant((int)Bits));
    }

    public Expression GetWriteSizeExpression(ParameterExpression total, Expression value)
    {
      return Expression.AddAssign(total, Expression.Constant((long)Bits));
    }
  }
}
