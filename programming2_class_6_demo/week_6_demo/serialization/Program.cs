using System.Text.Json;
using System;

namespace serialization
{
    internal class Program
    {
        const string FileBase = "../../../";
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            string selection = "";
            while (selection != "3")
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine("Menu: ");
                    Console.WriteLine("1. Create and save new user");
                    Console.WriteLine("2. Get saved user");
                    Console.WriteLine("3. Quit");
                    Console.WriteLine();
                    Console.Write("Enter selection: ");
                    selection = Console.ReadLine();
                    switch (selection)
                    {
                        case "1":
                            User user = CreateUser();
                            SerializeToFile(user);
                            Console.WriteLine("User saved to file");
                            break;
                        case "2":
                            User savedUser = GetSavedUser();
                            Console.WriteLine("Saved user: ");
                            Console.WriteLine(savedUser);
                            break;
                        case "3":
                            break;
                        default:
                            throw new InvalidDataException("Invalid selection");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public string GetFileName(string name)
        {
            return $"{FileBase}/users/{name}.json";
        }

        public User GetSavedUser()
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();
            StreamReader reader = new StreamReader(GetFileName(username));
            string json = reader.ReadToEnd();
            reader.Close();
            User user = JsonSerializer.Deserialize<User>(json);
            return user;
        }

        public User CreateUser()
        {
            Album neverGonnaGiveYouUp = new Album("Never Gonna Give You Up", "Rick Astley");
            Album shapeOfYou = new Album("Shape of You", "Ed Sheeran");
            Album rammstein = new Album("Rammstein", "Rammstein");

            List<Album> albums = new List<Album> {
                neverGonnaGiveYouUp,
                shapeOfYou,
                rammstein
            };

            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            return new User(username, albums);
        }

        public void SerializeToFile(User user)
        {
            string json = JsonSerializer.Serialize(user);
            StreamWriter streamWriter = new StreamWriter(GetFileName(user.Name));
            streamWriter.WriteLine(json);
            streamWriter.Close();
            Console.WriteLine("Object serialized and saved to file.");
        }
    }
}
