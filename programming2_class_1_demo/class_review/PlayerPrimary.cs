
namespace class_review
{
    // use of primary constroctor
    internal class PlayerPrimary(string name, uint score, uint level)
    {
        public uint Score { get; set; } = score;
        public string foo;

        // we may still define overload methods but, we must call the primary constructor 
        public PlayerPrimary(string name) : this(name, 0, 1) { }
        public void PrintInfo()
        {
            // access to primary constructor arguments
            // these work like fields and can be updated, i.e. score++;
            Console.WriteLine($"{name}, {score}, {level}");
        }
    }
}
