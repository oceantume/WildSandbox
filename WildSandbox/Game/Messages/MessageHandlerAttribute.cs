using System;

namespace WildSandbox.Game.Messages
{
  [AttributeUsage(AttributeTargets.Method)]
  public class MessageHandlerAttribute : Attribute
  {
    public MessageId Id { get; }

    public MessageHandlerAttribute(MessageId id)
    {
      Id = id;
    }

    public MessageHandlerAttribute(int id)
    {
      Id = (MessageId)id;
    }
  }
}
