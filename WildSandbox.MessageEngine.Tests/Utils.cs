using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildSandbox.Common;
using Xunit;

namespace WildSandbox.MessageEngine.Tests
{
  static class Utils
  {
    public static void TestWriteAndRead<T>(T initial, uint expectedSize) where T : class, new()
    {
      var engine = MessageEngine.Create();

      var stream = new MemoryStream(1024);
      var writer = new BitPackWriter(stream);

      Assert.Equal(expectedSize, engine.AddMessageSize(0, initial));

      engine.WriteMessageTo(writer, initial);

      stream.Position = 0;
      var reader = new BitPackReader(stream);

      var result = engine.ReadMessageFrom<T>(reader);
      Assert.Equal(initial, result);
    }
  }
}
