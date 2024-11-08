
namespace soc_log;


public class LogRepository
{
    public Log[] Logs { get; private set; } = new Log[100];
    public int Count { get; private set; } = 0;

    public void Add(Log log)
    {
        if (Count == Logs.Length - 1)
        {
            Console.WriteLine("Log is full!");
            return;
        }
        Logs[Count] = log;
        Count++;
    }

}
