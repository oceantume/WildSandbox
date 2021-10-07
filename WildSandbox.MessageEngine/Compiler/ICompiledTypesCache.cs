using System;

namespace WildSandbox.MessageEngine.Compiler
{
  interface ICompiledTypesCache
  {
    CompiledObjectWriter GetWriter(Type T);
    CompiledObjectReader GetReader(Type T);
  }
}
