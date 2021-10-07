using System;
using System.Linq.Expressions;
using System.Reflection;
using WildSandbox.Common;
using WildSandbox.MessageEngine.Exceptions;
using WildSandbox.MessageEngine.ValueExpressions;

namespace WildSandbox.MessageEngine.FieldExpressions
{
  class StaticArrayFieldExpressionBuilder : ArrayFieldExpressionBuilder
  {
    uint Length { get; }

    public StaticArrayFieldExpressionBuilder(IValueExpressionBuilder valueBuilder, PropertyInfo property, uint length)
      : base(valueBuilder, property)
    {
      Length = length;
    }

    public override Expression GetReaderExpression(ParameterExpression reader, ParameterExpression message)
    {
      return GetArrayLoopExpression(
        Aligned
          ? Expression.Call(reader, typeof(BitPackReader).GetMethod(nameof(BitPackReader.Align))!)
          : Expression.Empty(),
        Expression.Assign(
           Expression.Property(message, Property),
           Expression.NewArrayBounds(ElementType, Expression.Constant((int)Length))),
         value => 
          Expression.Assign(
            value,
            Expression.Convert(
              ValueBuilder.GetReaderExpression(reader),
              ElementType)));
    }

    public override Expression GetWriterExpression(ParameterExpression writer, ParameterExpression message)
    {
      return GetArrayLoopExpression(
        Aligned
          ? Expression.Call(writer, typeof(BitPackWriter).GetMethod(nameof(BitPackWriter.FlushByte))!)
          : Expression.Empty(),
        Expression.Property(message, Property),
        value => ValueBuilder.GetWriterExpression(writer, value));
    }

    public override Expression GetWriteSizeExpression(ParameterExpression total, ParameterExpression message)
    {
      return GetArrayLoopExpression(
        Aligned
          ? Expression.AddAssign(
              total,
              Expression.Subtract(
                Expression.Constant(8L),
                Expression.Modulo(total, Expression.Constant(8L))))
          : Expression.Empty(),
        Expression.Property(message, Property),
        value => ValueBuilder.GetWriteSizeExpression(total, value));
    }

    private Expression GetArrayLoopExpression(
      Expression prepare,
      Expression arrayExpr,
      Func<IndexExpression, Expression> createExpr)
    {
      var arrayVar = Expression.Variable(Property.PropertyType, "array");
      var lenVar = Expression.Variable(typeof(int), "length");
      var indexVar = Expression.Variable(typeof(int), "index");
      var breakLabel = Expression.Label("break");

      var variables = new[] { arrayVar, lenVar, indexVar };

      return Expression.Block(
        variables,
        prepare,
        Expression.Assign(arrayVar, arrayExpr),
        Expression.IfThenElse(
          Expression.Equal(arrayVar, Expression.Constant(null)),
          Expression.Assign(lenVar, Expression.Constant(0)),
          Expression.Assign(lenVar, Expression.ArrayLength(arrayVar))),
        Expression.Assign(indexVar, Expression.Constant(0)),
#if DEBUG
        Expression.IfThen(
          Expression.NotEqual(lenVar, Expression.Constant((int)Length)),
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
