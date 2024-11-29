
namespace interface_log
{
    internal interface ILoggable
    {
        int ID { get; }
        DateTime Created { get; }
        string GetLogMessage();

    }
}
