using System;
using System.Reflection;

namespace WildSandbox.MessageEngine.Exceptions
{
  public class NullPropertyException : ApplicationException
  {
    public NullPropertyException(PropertyInfo property)
      : base($"Message property {{{property}}} should not be null.")
    { }
  }
}
