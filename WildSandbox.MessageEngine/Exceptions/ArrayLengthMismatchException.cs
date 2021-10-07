using System;

namespace WildSandbox.MessageEngine.Exceptions
{
  public class ArrayLengthMismatchException : ApplicationException
  {
    public ArrayLengthMismatchException()
      : base("Array length did not match the value of its associated length parameter or its static length.")
    { }
  }
}
