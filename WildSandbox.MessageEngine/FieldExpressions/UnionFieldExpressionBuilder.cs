using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using WildSandbox.MessageEngine.Compiler;
using WildSandbox.MessageEngine.Exceptions;
using WildSandbox.MessageEngine.ValueExpressions;

namespace WildSandbox.MessageEngine.FieldExpressions
{
  class UnionFieldExpressionBuilder : IFieldExpressionBuilder
  {
    PropertyInfo Property { get; }
    PropertyInfo SelectorProperty { get; }
    ICompiledTypesCache Cache { get; }
    Dictionary<int, UnionEntry> UnionEntries { get; } = new Dictionary<int, UnionEntry>();

    record UnionEntry(PropertyInfo Property, StructureValueExpressionBuilder ValueBuilder);

    public UnionFieldExpressionBuilder(
      PropertyInfo property,
      PropertyInfo selectorProperty,
      ICompiledTypesCache cache)
    {
      Property = property;
      SelectorProperty = selectorProperty;
      Cache = cache;
    }

    public void AddMatch(int value, PropertyInfo property)
    {
      var valueBuilder = new StructureValueExpressionBuilder(property.PropertyType, Cache);
      UnionEntries[value] = new UnionEntry(property, valueBuilder);
    }

    public Expression GetReaderExpression(ParameterExpression reader, ParameterExpression message)
    {
      return GetUnionSwitchExpr(message, (entry, value) =>
        Expression.Assign(
          Expression.Property(message, Property),
          Expression.MemberInit(
            Expression.New(Property.PropertyType),
            Expression.Bind(
              entry.Property,
              Expression.Convert(
                entry.ValueBuilder.GetReaderExpression(reader),
                entry.Property.PropertyType)))));
    }

    public Expression GetWriterExpression(ParameterExpression writer, ParameterExpression message)
    {
      return GetUnionSwitchExpr(message, (entry, value) =>
        Expression.IfThenElse(
          Expression.Equal(
            Expression.Property(Expression.Property(message, Property), entry.Property),
            Expression.Constant(null)),
          Expression.Throw(
            Expression.New(
              typeof(NullPropertyException).GetConstructor(new[] { typeof(PropertyInfo) })!,
              Expression.Constant(entry.Property))),
          entry.ValueBuilder.GetWriterExpression(
            writer,
            Expression.Property(Expression.Property(message, Property), entry.Property))));
    }

    public Expression GetWriteSizeExpression(ParameterExpression total, ParameterExpression message)
    {
      return GetUnionSwitchExpr(message, (entry, value) =>
        entry.ValueBuilder.GetWriteSizeExpression(
          total,
          Expression.Property(
            Expression.Property(message, Property),
            entry.Property)));
    }

    private Expression GetUnionSwitchExpr(ParameterExpression message, Func<UnionEntry, int, Expression> createExpr)
    {
      var switchCases =
        UnionEntries.Select(x =>
          Expression.SwitchCase(
            createExpr(x.Value, x.Key),
            Expression.Constant(x.Key)));

      return Expression.Switch(
        typeof(void),
        Expression.Convert(Expression.Property(message, SelectorProperty), typeof(int)),
        Expression.Call(
          typeof(UnionFieldExpressionBuilder).GetMethod(nameof(ThrowUnknownSwitchCase), BindingFlags.Static | BindingFlags.Public)!,
          Expression.Convert(Expression.Property(message, SelectorProperty), typeof(int))),
        null,
        switchCases.ToArray());
    }

    public static void ThrowUnknownSwitchCase(int value)
    {
      throw new ApplicationException($"Unhandled switch case for value {value}.");
    }
  }
}
