using System.Linq.Expressions;

namespace WildSandbox.MessageEngine.FieldExpressions
{
  interface IFieldExpressionBuilder
  {
    Expression GetReaderExpression(ParameterExpression reader, ParameterExpression message);
    Expression GetWriterExpression(ParameterExpression writer, ParameterExpression message);
    Expression GetWriteSizeExpression(ParameterExpression total, ParameterExpression message);
  }
}
