
namespace class_review
{
    internal class Player
    {
        public string name;
        public uint score;
        public uint level;

        // using an overload method
        public Player(string name) : this(name, 0, 1)
        {
        }

        public Player(string name, uint score, uint level)
        {
            this.name = name;
            this.score = score;
            this.level = level;
        }
    }
}
