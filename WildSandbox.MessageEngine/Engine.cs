[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("WildSandbox.MessageEngine.Tests")]
namespace WildSandbox.MessageEngine
{
  public static class Engine
  {
    public static IMessageEngine CreateMessageEngine()
    {
      return MessageEngine.Create();
    }
  }
}
