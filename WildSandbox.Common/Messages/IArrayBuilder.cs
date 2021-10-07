namespace WildSandbox.Common.Messages
{
  public interface IArrayBuilder<M> : IFieldsBuilder<M>
  {
    public IFieldsBuilder<M> OfInteger();
    public IFieldsBuilder<M> OfInteger(int bits);
    public IFieldsBuilder<M> OfFloat();
    public IFieldsBuilder<M> OfString();
    public IFieldsBuilder<M> OfString(bool isFixed);
    public IFieldsBuilder<M> OfStructure();
    public IArrayBuilder<M> Aligned(bool aligned);
  }
}
