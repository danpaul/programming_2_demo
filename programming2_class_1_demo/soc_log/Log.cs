using System;

namespace soc_log;

public enum LogLevel
{
    info, warning, error
}

public class Log(LogLevel level, string message)
{
    public readonly DateTime created = DateTime.Now;
    public readonly string message = message;

    public readonly LogLevel level = level;

    public override string ToString()
    {
        return $"{level} - {created} - {message}";
    }

}
