namespace soc_log;

public class LogView(LogRepository logRepository)
{
    private LogRepository LogRepository { get; set; } = logRepository;

    public void Display()
    {
        string keepGoing;
        do
        {
            Log log = GetNewLog();
            LogRepository.Add(log);
            DisplayLogs();
            Console.Write("Continue (y/n)? ");
            keepGoing = Console.ReadLine();
        } while (keepGoing == "y");
    }

    public void DisplayLogs()
    {
        Console.WriteLine();
        for (int i = LogRepository.Count - 1; i >= 0; i--)
        {
            Log log = LogRepository.Logs[i];
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
