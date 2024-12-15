namespace todo
{

    public class Program
    {
        private List<string> todos = new List<string>();
        private const string filePath = "../../../todos.txt";

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        public void Start()
        {
            LoadTodos();

            string choice = "";
            while (choice != "4")
            {
                Console.WriteLine("\nTODO Application");
                Console.WriteLine("1. Add a Todo");
                Console.WriteLine("2. View Todos");
                Console.WriteLine("3. Remove a Todo");
                Console.WriteLine("4. Save and Exit");
                Console.Write("Choose an option: ");

                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddTodo();
                        break;
                    case "2":
                        ViewTodos();
                        break;
                    case "3":
                        RemoveTodo();
                        break;
                    case "4":
                        SaveTodos();
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private void LoadTodos()
        {

        }

        private void AddTodo()
        {
            Console.Write("Enter a new todo: ");
            string todo = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(todo))
            {
                todos.Add(todo);
                Console.WriteLine("Todo added.");
            }
            else
            {
                Console.WriteLine("Todo cannot be empty.");
            }
        }

        private void ViewTodos()
        {
            if (todos.Count == 0)
            {
                Console.WriteLine("No todos available.");
            }
            else
            {
                Console.WriteLine("\nYour Todos:");
                for (int i = 0; i < todos.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {todos[i]}");
                }
            }
        }

        private void RemoveTodo()
        {
            ViewTodos();
            if (todos.Count > 0)
            {
                Console.Write("Enter the number of the todo to remove: ");
                if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= todos.Count)
                {
                    todos.RemoveAt(index - 1);
                    Console.WriteLine("Todo removed.");
                }
                else
                {
                    Console.WriteLine("Invalid number. Please try again.");
                }
            }
        }

        private void SaveTodos()
        {

        }
    }
}
