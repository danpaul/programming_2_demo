
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
            /**
             * Constructor method ovlerloading
             */

            // Player objects constructed using three different constructor methods
            // View ./Player.cs to see the implementation details
            Player sara = new Player("Sara");

            uint score = 1000;
            uint level = 5;
            Player joe = new Player("Joe", score, level);

            int score2 = 2000;
            int level2 = 5;
            Player fabian = new Player("Fabian", score2, level2);

            /**
            * Static class methods. Note, we do not create an instance of the class to use
            *   the static methods.
            * 
            * View implementation in ./MyMath.cs
            */
            double radius = 10.3;
            double circleArea = MyMath.calculateCircleArea(radius);

        }
    }
}
