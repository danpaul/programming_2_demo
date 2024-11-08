namespace soc_log;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        LogRepository logRepository = new LogRepository();
        LogView logView = new LogView(logRepository);
        logView.Dislay();
    }
}
