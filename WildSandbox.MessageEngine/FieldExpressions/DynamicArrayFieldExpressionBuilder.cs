using System;
using System.Linq.Expressions;
using System.Reflection;
using WildSandbox.MessageEngine.Exceptions;
using WildSandbox.MessageEngine.ValueExpressions;

namespace WildSandbox.MessageEngine.FieldExpressions
{
  class DynamicArrayFieldExpressionBuilder : ArrayFieldExpressionBuilder
  {
    PropertyInfo LengthProperty { get; }

    public DynamicArrayFieldExpressionBuilder(
      IValueExpressionBuilder valueBuilder,
      PropertyInfo property,
      PropertyInfo lengthProperty)
      : base(valueBuilder, property)
    {
      LengthProperty = lengthProperty;
    }

    public override Expression GetReaderExpression(ParameterExpression reader, ParameterExpression message)
    {
      return GetArrayLoopExpression(
        message,
        Expression.Assign(
          Expression.Property(message, Property),
          Expression.NewArrayBounds(
            ElementType,
            Expression.Convert(
              Expression.Property(message, LengthProperty),
              typeof(int)))),
        value =>
          Expression.Assign(value, Expression.Convert(ValueBuilder.GetReaderExpression(reader), ElementType)));
    }

    public override Expression GetWriterExpression(ParameterExpression writer, ParameterExpression message)
    {
      return GetArrayLoopExpression(
        message,
        Expression.Property(message, Property),
        value => ValueBuilder.GetWriterExpression(writer, value));
    }

    public override Expression GetWriteSizeExpression(ParameterExpression total, ParameterExpression message)
    {
      return GetArrayLoopExpression(
        message,
        Expression.Property(message, Property),
        value => ValueBuilder.GetWriteSizeExpression(total, value));
    }

    private Expression GetArrayLoopExpression(
      ParameterExpression message,
      Expression arrayExpr,
      Func<IndexExpression, Expression> createExpr)
    {
      if (Aligned)
        throw new NotImplementedException("Aligned dynamic array is not implemented.");

      var arrayVar = Expression.Variable(Property.PropertyType, "array");
      var lenVar = Expression.Variable(typeof(int), "length");
      var indexVar = Expression.Variable(typeof(int), "index");
      var breakLabel = Expression.Label("break");

      var variables = new[] { arrayVar, lenVar, indexVar };

      return Expression.Block(
        variables,
        Expression.Assign(arrayVar, arrayExpr),
        Expression.IfThenElse(
          Expression.Equal(arrayVar, Expression.Constant(null)),
          Expression.Assign(lenVar, Expression.Constant(0)),
          Expression.Assign(lenVar, Expression.ArrayLength(arrayVar))),
        Expression.Assign(indexVar, Expression.Constant(0)),
#if DEBUG
        Expression.IfThen(
          Expression.NotEqual(lenVar, Expression.Convert(Expression.Property(message, LengthProperty), typeof(int))),
          Expression.Throw(Expression.New(typeof(ArrayLengthMismatchException)))),
#endif
        Expression.Loop(
          Expression.Block(
            Expression.IfThen(
              Expression.GreaterThanOrEqual(indexVar, lenVar),
              Expression.Break(breakLabel)),
            createExpr(Expression.ArrayAccess(arrayVar, indexVar)),
            Expression.PostIncrementAssign(indexVar)),
          breakLabel));
    }
  }
}
