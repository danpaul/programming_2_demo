namespace exception_user
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            User user = GetUser();
            Console.WriteLine(user);
        }

        User GetUser()
        {
            // nullable type!
            User? user = null;

            while (user == null)
            {
                try
                {
                    // throw custom exception
                    Console.Write("Enter user name: ");
                    string name = Console.ReadLine();
                    if (name.Length < 2)
                    {
                        throw new Exception("Username must be at least 2 characters");
                    }

                    // throw custom exception
                    Console.Write("Enter email: ");
                    string email = Console.ReadLine();
                    if (!email.Contains("@"))
                    {
                        throw new Exception("Email is invalid");
                    }

                    // rely on built in exception throwing
                    Console.Write("Enter your year of birth: ");
                    int yob = int.Parse(Console.ReadLine());
                    user = new User(name, email, yob);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            return user;
        }
    }
}
