
namespace interface_log
{
    public interface ILoggable
    {
        int ID { get; }
        DateTime Created { get; }
        string GetLogMessage();

    }
}
