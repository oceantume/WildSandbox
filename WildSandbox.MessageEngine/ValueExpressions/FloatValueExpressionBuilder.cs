using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WildSandbox.Common;

namespace WildSandbox.MessageEngine.ValueExpressions
{
  class FloatValueExpressionBuilder : IValueExpressionBuilder
  {
    public FloatValueExpressionBuilder() { }

    public Expression GetReaderExpression(ParameterExpression reader)
    {
      var readMethod = typeof(BitPackReader).GetMethod(nameof(BitPackReader.ReadFloat))!;
      return Expression.Call(reader, readMethod);
    }

    public Expression GetWriterExpression(ParameterExpression writer, Expression value)
    {
      var writeMethod = typeof(BitPackWriter).GetMethod(nameof(BitPackWriter.WriteFloat))!;
      return Expression.Call(writer, writeMethod, value);
    }

    public Expression GetWriteSizeExpression(ParameterExpression total, Expression value)
    {
      return Expression.AddAssign(total, Expression.Constant(32L));
    }
  }
}
