
namespace todo
{
    internal class Todo : ITodo
    {
        public string Text { get; }
        public bool IsCompleted { get; set; } = false;


        public Todo(string text)
        {
            Text = text;
        }

        public void SetCompleted(bool isCompleted)
        {
            IsCompleted = isCompleted;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
