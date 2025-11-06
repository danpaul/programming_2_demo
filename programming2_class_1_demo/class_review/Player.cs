
namespace class_review
{
    internal class Player
    {
        public string name;
        public uint score;
        public uint level;

        /**
         * Constructor method overloading is enabled when a class has multiple constructor methods.
         * 
         * This patterns allows instnaces of the class to be created when the constructor is called with varying numbers of arguments
         * 
         * As long as there is a constructor that matches, it will be used.
         */

        /**
         * Used when player is created like this:
         * 
         * Player player = new Player("Joe");
         * 
         * Note: `this` is used to call the constructor below, passing in default values and the `name` parameter.
         */
        public Player(string name) : this(name, 0, 1)
        {
        }

        /**
         * Used when Player is create like this:
         * 
         * Player player2 = new Player("Jolene", 2000, 5);
         */
        public Player(string name, uint score, uint level)
        {
            this.name = name;
            this.score = score;
            this.level = level;
        }

        /**
         * Finally, we can even have a constructor with the same number of arguments (just different argument types).
         * 
         * Used when player is created like this:
         * 
         * int score = 1000;
         * int level = 3;
         * Player player2 = new Player("Joshimo", score, level);
         */
        public Player(string name, int score, int level)
        {
            this.name = name;
            // here we are casting (changing the type) of a variable from int to uint
            this.score = (uint)score;
            this.level = (uint)level;
        }

        // better implementation that invokes the main constructor
        //public Player(string name, int score, int level) : this(name, (uint) score, (uint) level)
        //{
        //}
    }
}
