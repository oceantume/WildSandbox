using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using WildSandbox.MessageEngine.FieldExpressions;

namespace WildSandbox.MessageEngine.Compiler
{
  class OrderedFields : IEnumerable<IFieldExpressionBuilder>
  {
    public record FieldEntry(string Name, IFieldExpressionBuilder ExpressionBuilder);

    OrderedDictionary FieldsDictionary { get; } = new OrderedDictionary();

    public IEnumerator<IFieldExpressionBuilder> GetEnumerator()
    {
      throw new NotImplementedException();
    }

    public void Add(string name, IFieldExpressionBuilder expressionBuilder)
    {
      FieldsDictionary.Add(name, expressionBuilder);
    }

    public IFieldExpressionBuilder? Get(string name)
    {
      return (IFieldExpressionBuilder?)FieldsDictionary[name];
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      foreach (var key in FieldsDictionary.Keys)
      {
        yield return (IFieldExpressionBuilder)FieldsDictionary[key]!;
      }
    }

    IEnumerator<IFieldExpressionBuilder> IEnumerable<IFieldExpressionBuilder>.GetEnumerator()
    {
      foreach (var key in FieldsDictionary.Keys)
      {
        yield return (IFieldExpressionBuilder)FieldsDictionary[key]!;
      }
    }
  }
}
