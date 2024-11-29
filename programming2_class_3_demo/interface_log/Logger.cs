
namespace interface_log
{
    internal class Logger
    {
        ILoggable[] Logs = new ILoggable[100];
        int Count = 0;

        public void Add(ILoggable log)
        {
            if (Count == Logs.Length)
            {
                Console.WriteLine("log is full");
                return;
            }
            Logs[Count] = log;
            Count++;
        }

        public void DisplayLog(ILoggable log)
        {
            Console.WriteLine($"ID: {log.ID}, created at: {log.Created}, {log.GetLogMessage()}");
        }

        public void DisplayAll()
        {
            for (int i = 0; i < Count; i++)
            {
                DisplayLog(Logs[i]);
            }
        }

    }
}
