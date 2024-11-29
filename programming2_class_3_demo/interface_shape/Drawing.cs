
namespace interface_shape
{
    interface IShape
    {
        void Draw();
    }

    class Circle : IShape
    {
        public void Draw() { Console.WriteLine("drawing a circle"); }
    }

    class Square : IShape
    {
        public void Draw() { Console.WriteLine("drawing a square"); }
    }
    internal class Drawing
    {
        public void Main()
        {
            Random random = new Random();
            IShape shape = GetShape(random.Next(0, 2) == 1);
            Draw(shape);
        }
        public IShape GetShape(bool isCircle)
        {
            if (isCircle) return new Circle();
            return new Square();
        }

        public void Draw(IShape shape)
        {
            shape.Draw();
        }
    }
}
