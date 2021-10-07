using System;

namespace WildSandbox.Common.Messages
{
  [AttributeUsage(AttributeTargets.Class)]
  public class MessageAttribute : Attribute
  {
    public int Build { get; }
    public int Id { get; }

    public MessageAttribute(int build, int id)
    {
      Build = build;
      Id = id;
    }
  }
}
