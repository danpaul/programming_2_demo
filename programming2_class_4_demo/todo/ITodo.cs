
namespace todo
{
    internal interface ITodo
    {
        string Text { get; }
        bool IsCompleted { get; }

        void SetCompleted(bool isCompleted);
    }
}
