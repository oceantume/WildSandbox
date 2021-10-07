using System;
using System.Linq.Expressions;
using System.Reflection;
using WildSandbox.MessageEngine.ValueExpressions;

namespace WildSandbox.MessageEngine.FieldExpressions
{
  abstract class ArrayFieldExpressionBuilder : IFieldExpressionBuilder
  {
    public IValueExpressionBuilder ValueBuilder { get; }
    public PropertyInfo Property { get; }
    public Type ElementType { get; }
    public bool Aligned { get; set; }

    public ArrayFieldExpressionBuilder(IValueExpressionBuilder valueBuilder, PropertyInfo property)
    {
      var elementType = property.PropertyType.GetElementType();

      if (elementType == null)
        throw new ArgumentException("The property needs to be an array.");

      ValueBuilder = valueBuilder;
      Property = property;
      ElementType = elementType;
    }

    public abstract Expression GetReaderExpression(ParameterExpression reader, ParameterExpression message);
    public abstract Expression GetWriterExpression(ParameterExpression writer, ParameterExpression message);
    public abstract Expression GetWriteSizeExpression(ParameterExpression total, ParameterExpression message);
  }
}
