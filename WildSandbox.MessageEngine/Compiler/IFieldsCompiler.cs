namespace WildSandbox.MessageEngine.Compiler
{
  interface IFieldsCompiler
  {
    TDelegate CompileReader<TDelegate>();
    TDelegate CompileWriter<TDelegate>();
    TDelegate CompileSize<TDelegate>();
  }
}
