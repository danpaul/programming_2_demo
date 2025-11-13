namespace soc_log;

public class LogView()
{
    public bool ShouldContinue()
    {
        Console.Write("Continue (y/n)? ");
        string keepGoing = Console.ReadLine();
        return keepGoing.ToLower() == "y";
    }

    public void DisplayLogs(Log[] logs, int numberOfLogs)
    {
        Console.WriteLine();
        for (int i = numberOfLogs - 1; i >= 0; i--)
        {
            Log log = logs[i];
            if (log.level == LogLevel.info)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (log.level == LogLevel.warning)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.WriteLine(log);
            Console.ResetColor();
        }
        Console.WriteLine();
    }

    public Log GetNewLog()
    {
        Console.Write("Enter log level (info/warning/error): ");
        LogLevel level = (LogLevel)Enum.Parse(typeof(LogLevel), Console.ReadLine());
        Console.Write("Enter log message: ");
        string message = Console.ReadLine();
        return new Log(level, message);
    }

}
