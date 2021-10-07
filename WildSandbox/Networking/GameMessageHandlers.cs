using System;
using System.Collections.Immutable;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using WildSandbox.Game.Messages;

namespace WildSandbox.Networking
{
  class GameMessageHandlers<TSession>
  {
    private ImmutableDictionary<MessageId, MessageHandler> Handlers { get; init; }

    private GameMessageHandlers(ImmutableDictionary<MessageId, MessageHandler> handlers)
    {
      Handlers = handlers;
    }

    public bool TryGetHandler(MessageId id, out MessageHandler handler)
      => Handlers.TryGetValue(id, out handler!);

    public delegate void MessageHandlerCallback(TSession session, object message);
    public record MessageHandler(Type MessageType, MessageHandlerCallback Callback);

    public static GameMessageHandlers<TSession> CreateFromReflection()
    {
      var handlers = Assembly.GetExecutingAssembly()
        .GetTypes()
        .SelectMany(t => t.GetMethods())
        .Select(m => new { Method = m, Attribute = m.GetCustomAttribute<MessageHandlerAttribute>() })
        .Where(x => x.Attribute != null && x.Method.GetParameters()[0].ParameterType == typeof(TSession))
        .ToImmutableDictionary(
          x => x.Attribute!.Id,
          x => CreateHandler(x.Method));

      return new GameMessageHandlers<TSession>(handlers);
    }

    private static MessageHandler CreateHandler(MethodInfo method)
    {
      var parameters = method.GetParameters();
      var sessionParam = parameters[0];
      var messageParam = parameters[1];

      var sessionParamExpr = Expression.Parameter(typeof(TSession), "session");
      var messageParamExpr = Expression.Parameter(typeof(object), "message");

      var callExpr = Expression.Call(method,
        sessionParamExpr,
        Expression.Convert(messageParamExpr, messageParam.ParameterType));

      var lambdaExpr = Expression.Lambda<MessageHandlerCallback>(callExpr,
        sessionParamExpr,
        messageParamExpr);

      return new MessageHandler(messageParam.ParameterType, lambdaExpr.Compile());
    }
  }
}