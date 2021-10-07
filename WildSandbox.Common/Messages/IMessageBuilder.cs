namespace WildSandbox.Common.Messages
{
  public interface IMessageBuilder
  {
    IFieldsBuilder<TMsg> FieldsOf<TMsg>();
  }
}
