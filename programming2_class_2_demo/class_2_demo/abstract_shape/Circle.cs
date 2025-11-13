
namespace abstract_shape
{
    // Circle inherits from abstract class shape
    internal class Circle : Shape
    {
        protected int Radius { get; set; }

        // we must define an implementation for abstract properties
        public override double Area
        {
            get
            {
                return Math.PI * Radius * Radius;
            }
        }

        // since the base class has a constructor with parameters, we must call it
        public Circle(int xPosition, int yPosition, int radius) : base(xPosition, yPosition)
        {
            Radius = radius;
        }

        // we must define an implementation for abstract methods
        public override void Draw()
        {
            Console.WriteLine($"Drawing a circle of size: {Area}");
        }
    }
}
