using System;
using WildSandbox.Common;

namespace WildSandbox.MessageEngine
{
  public interface IMessageEngine
  {
    public object ReadMessageFrom(BitPackReader reader, Type messageType);
    public T ReadMessageFrom<T>(BitPackReader reader) where T : class, new();
    public void WriteMessageTo(BitPackWriter writer, object message);
    public void WriteMessageTo<T>(BitPackWriter writer, T message) where T : class, new();
    public long AddMessageSize(long position, object message);
    public long AddMessageSize<T>(long position, T message) where T : class, new();
  }
}
