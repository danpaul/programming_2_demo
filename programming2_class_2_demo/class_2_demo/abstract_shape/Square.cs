using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_shape
{
    // Square inherits from abstract class shape
    internal class Square : Shape
    {
        protected int Length { get; set; }

        // we must define an implementation for abstract properties
        public override double Area
        {
            get
            {
                return Length * Length;
            }
        }

        // since the base class has a constructor with parameters, we must call it
        public Square(int xPosition, int yPosition, int length) : base(xPosition, yPosition)
        {
            Length = length;
        }

        // we must define an implementation for abstract methods
        public override void Draw()
        {
            Console.WriteLine($"Drawing a square of size: {Area}");
        }
    }
}
