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
        // the log repositor and log view are separate so that each manages only a single concern
        LogRepository logRepository = new LogRepository();
        LogView logView = new LogView(logRepository);
        logView.Dislay();
    }
}
