using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WildSandbox.MessageEngine.ValueExpressions
{
  interface IValueExpressionBuilder
  {
    Expression GetReaderExpression(ParameterExpression reader);
    Expression GetWriterExpression(ParameterExpression writer, Expression value);
    Expression GetWriteSizeExpression(ParameterExpression total, Expression value);
  }
}
