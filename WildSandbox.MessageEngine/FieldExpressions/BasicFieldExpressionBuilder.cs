using System.Linq.Expressions;
using System.Reflection;
using WildSandbox.MessageEngine.ValueExpressions;

namespace WildSandbox.MessageEngine.FieldExpressions
{
  /// <summary>
  /// Supports basic fields with simple access/assignment.
  /// For example, Msg.MyField = read() and write(Msg.MyField).
  /// </summary>
  class BasicFieldExpressionBuilder : IFieldExpressionBuilder
  {
    IValueExpressionBuilder ValueBuilder { get; }
    PropertyInfo Property { get; }

    public BasicFieldExpressionBuilder(IValueExpressionBuilder valueBuilder, PropertyInfo property)
    {
      ValueBuilder = valueBuilder;
      Property = property;
    }

    public BasicFieldExpressionBuilder(PropertyInfo property, IValueExpressionBuilder valueBuilder)
    {
      ValueBuilder = valueBuilder;
      Property = property;
    }

    public Expression GetReaderExpression(ParameterExpression reader, ParameterExpression message)
    {
      return Expression.Assign(
       Expression.Property(message, Property),
       Expression.Convert(ValueBuilder.GetReaderExpression(reader), Property.PropertyType));
    }

    public Expression GetWriterExpression(ParameterExpression writer, ParameterExpression message)
    {
      var valueExpr = Expression.Property(message, Property);
      return ValueBuilder.GetWriterExpression(writer, valueExpr);
    }

    public Expression GetWriteSizeExpression(ParameterExpression total, ParameterExpression message)
    {
      var valueExpr = Expression.Property(message, Property);
      return ValueBuilder.GetWriteSizeExpression(total, valueExpr);
    }
  }
}
