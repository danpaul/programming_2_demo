namespace list_letter_guess
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
            string doContinue;
            List<char> blacklist = new List<char>();
            do
            {
                char newLetter = GuessLetter(blacklist);
                blacklist.Add(newLetter);
                Console.Write("Currently guessed letter(s): ");
                foreach (char letter in blacklist)
                {
                    Console.Write($"{letter} ");
                }
                Console.WriteLine();
                Console.Write("Would you like to continue (y/n)? ");
                doContinue = Console.ReadLine();
            } while (doContinue != "n");
        }

        // take a List<char> of blacklist letters
        // gets input from user until user enters a letter not in the blacklist
        // returns new char
        char GuessLetter(List<char> blacklist)
        {
            char letter;
            do
            {
                Console.Write("Enter a letter: ");
                string line = Console.ReadLine();
                letter = line[0];
            } while (blacklist.Contains(letter));

            return letter;
        }
    }
}
