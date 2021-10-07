using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using WildSandbox.Common;

namespace WildSandbox.MessageEngine.ValueExpressions
{
  class StringValueExpressionBuilder : IValueExpressionBuilder
  {
    public bool IsWide { get; set; }

    public StringValueExpressionBuilder(bool isWide)
    {
      IsWide = isWide;
    }

    public Expression GetReaderExpression(ParameterExpression reader)
    {
      var readMethod = typeof(BitPackReader).GetMethod(nameof(BitPackReader.ReadString))!;
      return Expression.Call(reader, readMethod, Expression.Constant(IsWide));
    }

    public Expression GetWriterExpression(ParameterExpression writer, Expression value)
    {
      var writeMethod = typeof(BitPackWriter).GetMethod(nameof(BitPackWriter.WriteString))!;
      return Expression.Call(writer, writeMethod, value, Expression.Constant(IsWide));
    }

    public Expression GetWriteSizeExpression(ParameterExpression total, Expression value)
    {
      var method = typeof(StringValueExpressionBuilder).GetMethod(
        nameof(GetStringBits), BindingFlags.Static | BindingFlags.NonPublic)!;

      return Expression.AddAssign(
        total,
        Expression.Call(
          null,
          method,
          value,
          Expression.Constant(IsWide)));
    }

    /// <summary>
    /// Gets the size in bits for a string. We're cheating a little here but this prevents a lot of complexity.
    /// </summary>
    private static long GetStringBits(string? value, bool wide)
    {
      var encoding = wide ? Encoding.Unicode : Encoding.ASCII;
      var length = encoding.GetByteCount(value ?? "");
      var extended = length * 2 > 0x7F;
      int leadingBits = 1 + (extended ? 15 : 7);
      return leadingBits + length * 8;
    }
  }
}
