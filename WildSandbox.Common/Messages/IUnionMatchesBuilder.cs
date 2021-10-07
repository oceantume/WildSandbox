using System;
using System.Linq.Expressions;

namespace WildSandbox.Common.Messages
{
  public interface IUnionMatchesBuilder<TUnion>
  {
    public IUnionMatchesBuilder<TUnion> Match<TMatch, TRef>(Expression<Func<TUnion, TMatch>> expr, TRef value);
  }
}
