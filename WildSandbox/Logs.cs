using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace WildSandbox
{
  public static class Logs
  {
    private static readonly ConcurrentQueue<LogQueueEntry> m_queue = new ConcurrentQueue<LogQueueEntry>();
    private static readonly Thread m_thread;
    private static readonly StreamWriter m_writer;

    static Logs()
    {
      string dir = Environment.CurrentDirectory + "/logs";

      Directory.CreateDirectory(dir);

      m_writer = new StreamWriter(File.Open($"{dir}/{DateTime.Now.ToString("yyyyMMddHHmmssffff")}.txt", FileMode.Create));

      m_thread = new Thread(() =>
      {
        while (true)
        {
          LogQueueEntry entry;
          if (!m_queue.TryDequeue(out entry!))
          {
            Thread.Sleep(100);
            continue;
          }

          if ((entry.Level & LogLevel.FileOnly) == 0)
          {
            if (entry.Level == LogLevel.Error || entry.Level == LogLevel.Exception)
              Console.ForegroundColor = ConsoleColor.Red;
            else if (entry.Level == LogLevel.Warning)
              Console.ForegroundColor = ConsoleColor.Yellow;
            else
              Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(entry);
          }

          m_writer.WriteLine(entry.ToString());
          m_writer.Flush();
        }
      });

      m_thread.IsBackground = true;
      m_thread.Start();
    }

    public static void Log(string log, params object?[] formatargs)
    {
      Log(string.Format(log, formatargs));
    }

    public static void Log(string log)
    {
      Log(LogType.None, LogLevel.Info, log);
    }

    public static void Log(LogType type, string log, params object?[] formatargs)
    {
      Log(type, string.Format(log, formatargs));
    }

    public static void Log(LogType type, string log)
    {
      Log(type, LogLevel.Info, log);
    }

    public static void Log(LogType type, LogLevel level, string log, params object?[] formatargs)
    {
      Log(type, level, string.Format(log, formatargs));
    }

    public static void Log(LogType type, LogLevel level, string log)
    {
      m_queue.Enqueue(new LogQueueEntry(type, level, log));
    }

    public static void Log(byte[] buffer)
    {
      Log(LogType.None, LogLevel.Info, buffer);
    }

    public static void Log(LogType type, byte[]? buffer)
    {
      Log(type, LogLevel.Info, buffer);
    }

    public static void Log(LogType type, LogLevel level, byte[]? buffer)
    {
      Log(type, level, GetBufferString(buffer));
    }

    public static string GetBufferString(MemoryStream stream)
    {
      var buffer = stream.GetBuffer().AsSpan(0, (int)stream.Length);
      return GetBufferString(buffer);
    }

    public static string GetBufferString(Span<byte> buffer)
    {
      if (buffer == null)
        return "[Null buffer]";

      StringBuilder sb = new StringBuilder();

      sb.AppendLine("");
      sb.AppendLine("|----------------------------------------------------------------|");
      sb.AppendLine("| 00  01  02  03  04  05  06  07  08  09  0A  0B  0C  0D  0E  0F |");
      sb.AppendLine("|----------------------------------------------------------------|");
      sb.Append("|");

      for (int i = 0; i < buffer.Length; i++)
      {
        sb.Append(string.Format(" {0:x2} ", buffer[i].ToString("X2")));

        if (i % 0x10 == 0xF)
        {
          sb.Append("|");
          sb.AppendLine();
          sb.Append("|");
        }
      }

      sb.AppendLine("");
      sb.AppendLine("|----------------------------------------------------------------|");

      return sb.ToString();
    }

    class LogQueueEntry
    {
      public LogQueueEntry(LogType type, LogLevel level, string str)
      {
        Type = type;
        Level = level;
        Text = str;
      }

      public LogType Type { get; set; }
      public LogLevel Level { get; set; }
      public string Text { get; set; }

      public override string ToString()
      {
        if (Type == LogType.None)
          return Text;
        else
          return string.Format("[{0}] {1}", Type.ToString(), Text);
      }
    }
  }

  public enum LogType
  {
    None,
    General,
    DB,
    Auth,
    Realm,
    Packet,
    Network,
    Compiler,
  }

  public enum LogLevel
  {
    Info = 0,
    Warning = 1,
    Error = 2,
    Exception = 3,
    FileOnly = 0x100,
  }
}
