namespace abstract_shape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        public void Start()
        {
            // Review the abstract Shape class in ./Shape.cs
            // Review the derived classes (Circle, Square)

            // create a Square object which inherits from abstract base class Shape
            Square square = new Square(10, 20, 10);

            // create a Circle object which inherits from abstract base class Shape
            Circle circle = new Circle(10, 20, 5);

            // call the abstract method Draw implemented by both derived classes
            square.Draw();
            circle.Draw();

            Console.WriteLine("\nCurrent positions:");

            // call the DisplayPostion method implemented in the abstract base class
            square.DisplayPosition();
            circle.DisplayPosition();
        }
    }
}
