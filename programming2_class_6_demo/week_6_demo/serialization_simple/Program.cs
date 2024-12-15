namespace serialization_simple
{
    internal class Program
    {
        const string filePath = "../../../users.txt";
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            List<User> users = new List<User>();

            // read all users from file
            if (File.Exists(filePath))
            {
                StreamReader sr = new StreamReader(filePath);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    User savedUser = User.Deserialize(line);
                    users.Add(savedUser);
                }
                sr.Close();
            }

            // add a new user
            Console.Write("Enter user name: ");
            string name = Console.ReadLine();

            Console.Write("Enter user age: ");
            int age = int.Parse(Console.ReadLine());

            User newUser = new User(name, age);
            users.Add(newUser);

            // display users
            Console.Write("\nUsers:");
            foreach (User u in users)
            {
                Console.WriteLine(u);
            }

            // save users to file
            StreamWriter streamWriter = new StreamWriter(filePath);
            foreach (User u in users)
            {
                streamWriter.WriteLine(User.Serialize(u));
            }
            streamWriter.Close();

        }
    }
}
