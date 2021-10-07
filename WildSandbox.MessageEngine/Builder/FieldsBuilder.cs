using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using WildSandbox.Common.Messages;
using WildSandbox.MessageEngine.Compiler;
using WildSandbox.MessageEngine.FieldExpressions;
using WildSandbox.MessageEngine.ValueExpressions;

namespace WildSandbox.MessageEngine.Builder
{
  class FieldsBuilder<TMsg> : IFieldsBuilder<TMsg>, IArrayBuilder<TMsg>
  {
    OrderedFields Fields { get; }
    ICompiledTypesCache Cache { get; }

    /// <summary>
    /// This is the last array's element value and is used to implement IArrayBuilder.
    /// </summary>
    //IValueExpressionBuilder? ElementValueExpressionBuilder { get; set; }
    IFieldExpressionBuilder? CurrentFieldExpressionBuilder { get; set; }

    public FieldsBuilder(ICompiledTypesCache cache, OrderedFields fields)
    {
      Cache = cache;
      Fields = fields;
    }

    private void AddField(string name, IFieldExpressionBuilder fieldExpressionBuilder)
    {
      Fields.Add(name, fieldExpressionBuilder);
      CurrentFieldExpressionBuilder = fieldExpressionBuilder;
    }

    #region IFieldsBuilder Implementation

    public IFieldsBuilder<TMsg> Integer<T>(Expression<Func<TMsg, T>> expr)
    {
      return Integer(expr, Marshal.SizeOf<T>() * 8);
    }

    public IFieldsBuilder<TMsg> Integer<T>(Expression<Func<TMsg, T>> expr, int bits)
    {
      var property = GetPropertyFromExpr(expr);

      AddField(
        property.Name,
        new BasicFieldExpressionBuilder(
           new IntegerValueExpressionBuilder(typeof(T), bits),
           property));

      return this;
    }

    public IFieldsBuilder<TMsg> Float(Expression<Func<TMsg, float>> expr)
    {
      var property = GetPropertyFromExpr(expr);

      AddField(
        property.Name,
          new BasicFieldExpressionBuilder(
            new FloatValueExpressionBuilder(),
            property));

      return this;
    }

    public IFieldsBuilder<TMsg> String(Expression<Func<TMsg, string?>> expr)
    {
      return String(expr, false);
    }

    public IFieldsBuilder<TMsg> String(Expression<Func<TMsg, string?>> expr, bool isWide)
    {
      var property = GetPropertyFromExpr(expr);

      AddField(
        property.Name,
          new BasicFieldExpressionBuilder(
            new StringValueExpressionBuilder(isWide),
            property));

      return this;
    }

    public IArrayBuilder<TMsg> Array<T>(Expression<Func<TMsg, T[]?>> expr, uint length)
    {
      var property = GetPropertyFromExpr(expr);

      AddField(
        property.Name,
        new StaticArrayFieldExpressionBuilder(
          GetValueExpressionBuilderForElementType(typeof(T)),
          property,
          length));

      return this;
    }

    public IArrayBuilder<TMsg> Array<T, TRef>(Expression<Func<TMsg, T[]?>> expr, Expression<Func<TMsg, TRef>> lengthExpr)
    {
      var property = GetPropertyFromExpr(expr);

      AddField(
        property.Name,
        new DynamicArrayFieldExpressionBuilder(
          GetValueExpressionBuilderForElementType(typeof(T)),
          property,
          GetPropertyFromExpr(lengthExpr)));

      return this;
    }

    public IFieldsBuilder<TMsg> Structure<T>(Expression<Func<TMsg, T?>> expr)
    {
      var property = GetPropertyFromExpr(expr);

      AddField(
        property.Name,
        new BasicFieldExpressionBuilder(
          new StructureValueExpressionBuilder(property.PropertyType, Cache),
          property));

      return this;
    }

    public IFieldsBuilder<TMsg> Union<T, TRef>(Expression<Func<TMsg, T?>> expr, Expression<Func<TMsg, TRef>> selectorExpr, Action<IUnionMatchesBuilder<T>> buildMatches)
    {
      var property = GetPropertyFromExpr(expr);
      var selectorProperty = GetPropertyFromExpr(selectorExpr);
      var expressionBuilder = new UnionFieldExpressionBuilder(property, selectorProperty, Cache);

      AddField(property.Name, expressionBuilder);
      buildMatches(new UnionMatchBuilder<T>(expressionBuilder));

      return this;
    }

    class UnionMatchBuilder<TUnion> : IUnionMatchesBuilder<TUnion>
    {
      UnionFieldExpressionBuilder ExpressionBuilder { get; }

      public UnionMatchBuilder(UnionFieldExpressionBuilder builder)
      {
        ExpressionBuilder = builder;
      }

      public IUnionMatchesBuilder<TUnion> Match<TMatch, TRef>(Expression<Func<TUnion, TMatch>> expr, TRef value)
      {
        ExpressionBuilder.AddMatch(Convert.ToInt32(value), GetPropertyFromExpr(expr));
        return this;
      }

      private static PropertyInfo GetPropertyFromExpr<T>(Expression<Func<TUnion, T>> expr)
      {
        if (expr.Body is MemberExpression memberSelectorExpr)
        {
          var property = memberSelectorExpr.Member as PropertyInfo;
          if (property != null)
          {
            return property;
          }
        }

        throw new ArgumentException("Unexpected expression used in message builder.", nameof(expr));
      }
    }

    #endregion

    #region IArrayBuilder Implementation

    public IFieldsBuilder<TMsg> OfInteger()
    {
      if (CurrentFieldExpressionBuilder is not ArrayFieldExpressionBuilder fieldBuilder)
        throw new ApplicationException("The property is not an array.");

      if (fieldBuilder.ValueBuilder is not IntegerValueExpressionBuilder)
        throw new ApplicationException("The property is not an array of integer.");

      return this;
    }

    public IFieldsBuilder<TMsg> OfInteger(int bits)
    {
      if (CurrentFieldExpressionBuilder is not ArrayFieldExpressionBuilder fieldBuilder)
        throw new ApplicationException("The property is not an array.");

      if (fieldBuilder.ValueBuilder is not IntegerValueExpressionBuilder valueBuilder)
        throw new ApplicationException("The property is not an array of integer.");

      valueBuilder.Bits = bits;

      return this;
    }

    public IFieldsBuilder<TMsg> OfFloat()
    {
      if (CurrentFieldExpressionBuilder is not ArrayFieldExpressionBuilder fieldBuilder)
        throw new ApplicationException("The property is not an array.");

      if (fieldBuilder.ValueBuilder is not FloatValueExpressionBuilder)
        throw new ApplicationException("The property is not an array of float.");

      return this;
    }

    public IFieldsBuilder<TMsg> OfString()
    {
      if (CurrentFieldExpressionBuilder is not ArrayFieldExpressionBuilder fieldBuilder)
        throw new ApplicationException("The property is not an array.");

      if (fieldBuilder.ValueBuilder is not StringValueExpressionBuilder)
        throw new ApplicationException("The property is not an array of string.");

      return this;
    }

    public IFieldsBuilder<TMsg> OfString(bool isFixed)
    {
      if (CurrentFieldExpressionBuilder is not ArrayFieldExpressionBuilder fieldBuilder)
        throw new ApplicationException("The property is not an array.");

      if (fieldBuilder.ValueBuilder is not StringValueExpressionBuilder valueBuilder)
        throw new ApplicationException("The property is not an array of string.");

      valueBuilder.IsWide = isFixed;

      return this;
    }

    public IFieldsBuilder<TMsg> OfStructure()
    {
      if (CurrentFieldExpressionBuilder is not ArrayFieldExpressionBuilder fieldBuilder)
        throw new ApplicationException("The property is not an array.");

      if (fieldBuilder.ValueBuilder is not StructureValueExpressionBuilder)
        throw new ApplicationException("The property is not an array of object.");

      return this;
    }

    public IArrayBuilder<TMsg> Aligned(bool aligned)
    {
      if (CurrentFieldExpressionBuilder is not ArrayFieldExpressionBuilder fieldBuilder)
        throw new ApplicationException("The property is not an array.");

      fieldBuilder.Aligned = aligned;

      return this;
    }

    #endregion

    #region Utilities
    private static PropertyInfo GetPropertyFromExpr<T>(Expression<Func<TMsg, T>> expr)
    {
      if (expr.Body is MemberExpression memberSelectorExpr)
      {
        var property = memberSelectorExpr.Member as PropertyInfo;
        if (property != null)
        {
          return property;
        }
      }

      throw new ArgumentException("Unexpected expression used in message builder.", nameof(expr));
    }

    private IValueExpressionBuilder GetValueExpressionBuilderForElementType(Type type)
    {
      if (type == typeof(sbyte))
        return new IntegerValueExpressionBuilder(typeof(sbyte), 8);
      else if (type == typeof(byte))
        return new IntegerValueExpressionBuilder(typeof(byte), 8);
      else if (type == typeof(short))
        return new IntegerValueExpressionBuilder(typeof(short), 16);
      else if (type == typeof(ushort))
        return new IntegerValueExpressionBuilder(typeof(ushort), 16);
      else if (type == typeof(int))
        return new IntegerValueExpressionBuilder(typeof(int), 32);
      else if (type == typeof(uint))
        return new IntegerValueExpressionBuilder(typeof(uint), 32);
      else if (type == typeof(long))
        return new IntegerValueExpressionBuilder(typeof(long), 64);
      else if (type == typeof(ulong))
        return new IntegerValueExpressionBuilder(typeof(ulong), 64);
      else if (type == typeof(float))
        return new FloatValueExpressionBuilder();
      else if (type == typeof(string))
        return new StringValueExpressionBuilder(false);
      else if (type.IsClass)
        return new StructureValueExpressionBuilder(type, Cache);
      else
        throw new ArgumentException("Attempting to build a message value for an unrecognized type.", nameof(type));
    }
    #endregion
  }
}
