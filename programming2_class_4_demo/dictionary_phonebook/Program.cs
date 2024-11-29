namespace dictionary_phonebook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create dictionary
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            while (true)
            {
                Console.WriteLine("\nPhone Book Menu:");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Find Contact");
                Console.WriteLine("3. Display All Contacts");
                Console.WriteLine("4. Remove Contact");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter phone number: ");
                        string phone = Console.ReadLine();

                        phoneBook[name] = phone; // Add or update contact
                        Console.WriteLine($"Contact {name} added/updated.");
                        break;

                    case "2":
                        Console.Write("Enter name to search: ");
                        string searchName = Console.ReadLine();

                        if (phoneBook.ContainsKey(searchName))
                            Console.WriteLine($"Phone number for {searchName}: {phoneBook[searchName]}");
                        else
                            Console.WriteLine($"Contact {searchName} not found.");
                        break;

                    case "3":
                        Console.WriteLine("Phone Book:");
                        foreach (var contact in phoneBook)
                            Console.WriteLine($"{contact.Key}: {contact.Value}");
                        // alternate loop
                        //foreach (string key in phoneBook.Keys)
                        //{
                        //    Console.WriteLine($"{key}: {phoneBook[key]}");
                        //}
                        break;

                    case "4":
                        Console.Write("Enter name to remove: ");
                        string removeName = Console.ReadLine();

                        if (phoneBook.Remove(removeName))
                            Console.WriteLine($"Contact {removeName} removed.");
                        else
                            Console.WriteLine($"Contact {removeName} not found.");
                        break;

                    case "5":
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
    }
}
