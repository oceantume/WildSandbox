using System;
using System.Linq.Expressions;

namespace WildSandbox.Common.Messages
{
  public interface IFieldsBuilder<TMsg>
  {
    // TODO: Add enum support (can ints support them by default?)
    public IFieldsBuilder<TMsg> Integer<T>(Expression<Func<TMsg, T>> expr);
    public IFieldsBuilder<TMsg> Integer<T>(Expression<Func<TMsg, T>> expr, int bits);
    public IFieldsBuilder<TMsg> Float(Expression<Func<TMsg, float>> expr);
    public IFieldsBuilder<TMsg> String(Expression<Func<TMsg, string?>> expr);
    public IFieldsBuilder<TMsg> String(Expression<Func<TMsg, string?>> expr, bool isWide);
    public IArrayBuilder<TMsg> Array<T>(Expression<Func<TMsg, T[]?>> expr, uint length);
    public IArrayBuilder<TMsg> Array<T, TRef>(Expression<Func<TMsg, T[]?>> expr, Expression<Func<TMsg, TRef>> lengthExpr);
    public IFieldsBuilder<TMsg> Structure<T>(Expression<Func<TMsg, T?>> expr);
    public IFieldsBuilder<TMsg> Union<T, TRef>(Expression<Func<TMsg, T?>> expr, Expression<Func<TMsg, TRef>> selectorExpr, Action<IUnionMatchesBuilder<T>> matchBuilder);
  }
}
