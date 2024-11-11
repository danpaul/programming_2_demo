
namespace class_review
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
            // create player using regular constructor and overlaod constructor
            Player player1 = new Player("Joe", 1000, 3);
            Player player2 = new Player("Sara");

            // use primary constructor to create a new player
            PlayerPrimary player3 = new PlayerPrimary("Andrew");
        }
    }
}
