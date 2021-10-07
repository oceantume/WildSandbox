using System;
using System.Collections.Generic;
using System.Reflection;
using WildSandbox.Common;
using WildSandbox.Common.Messages;
using WildSandbox.MessageEngine.Builder;
using WildSandbox.MessageEngine.Compiler;

[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("WildSandbox.MessageEngine.Tests")]
namespace WildSandbox.MessageEngine
{
  class MessageEngine : IMessageEngine, ICompiledTypesCache
  {
    private Dictionary<Type, CompiledObjectWriter> CompiledWriters { get; }
      = new Dictionary<Type, CompiledObjectWriter>();

    private Dictionary<Type, CompiledObjectReader> CompiledReaders { get; }
      = new Dictionary<Type, CompiledObjectReader>();

    private MessageEngine() { }

    public static IMessageEngine Create()
    {
      return new MessageEngine();
    }

    public object ReadMessageFrom(BitPackReader reader, Type messageType)
    {
      var compiledReader = GetReader(messageType);
      return compiledReader.ReadFieldsFrom(reader);
    }

    public T ReadMessageFrom<T>(BitPackReader reader) where T : class, new()
    {
      var compiledReader = GetReader(typeof(T));
      return (T)compiledReader.ReadFieldsFrom(reader);
    }

    public void WriteMessageTo<T>(BitPackWriter writer, T message) where T : class, new()
    {
      var compiledWriter = GetWriter(typeof(T));
      compiledWriter.WriteFieldsTo(writer, message);
      writer.FlushByte();
    }

    public void WriteMessageTo(BitPackWriter writer, object message)
    {
      var compiledWriter = GetWriter(message.GetType());
      compiledWriter.WriteFieldsTo(writer, message);
      writer.FlushByte();
    }

    public long AddMessageSize<T>(long position, T message) where T : class, new()
    {
      var compiledWriter = GetWriter(typeof(T));
      return compiledWriter.AddFieldsSize(position, message);
    }

    public long AddMessageSize(long position, object message)
    {
      var compiledWriter = GetWriter(message.GetType());
      return compiledWriter.AddFieldsSize(position, message);
    }

    public CompiledObjectWriter GetWriter(Type type)
    {
      if (!CompiledWriters.TryGetValue(type, out var compiledWriter))
      {
        var compiler = GenerateCompilerForType(type);

        compiledWriter = new CompiledObjectWriter(
          compiler.CompileWriter<WriteFieldsToDelegate>(),
          compiler.CompileSize<AddFieldsSizeDelegate>());

        CompiledWriters.Add(type, compiledWriter);
      }

      return compiledWriter;
    }

    public CompiledObjectReader GetReader(Type type)
    {
      if (!CompiledReaders.TryGetValue(type, out var compiledReader))
      {
        var compiler = GenerateCompilerForType(type);

        compiledReader = new CompiledObjectReader(
          compiler.CompileReader<ReadFieldsFromDelegate>());
        CompiledReaders.Add(type, compiledReader);
      }

      return compiledReader;
    }

    private IFieldsCompiler GenerateCompilerForType(Type type)
    {
      var builder = new MessageBuilder(this);
      InvokeStaticBuildMethod(type, builder);

      var compiler = builder.GetFieldsCompiler();

      if (compiler == null)
        throw new ApplicationException(
          $"Invalid builder state. The Build method of {type.Name} may not be properly implemented.");

      return compiler;
    }

    private static void InvokeStaticBuildMethod(Type type, IMessageBuilder builder)
    {
      var methodInfo = type.GetMethod("Build", BindingFlags.Public | BindingFlags.Static);

      if (methodInfo == null)
        throw new ArgumentException("Message type is missing a Build function.", nameof(type));

      methodInfo.Invoke(null, new object[] { builder });
    }
  }
}
