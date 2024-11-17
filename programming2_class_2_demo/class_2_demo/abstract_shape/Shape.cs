using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_shape
{
    // use the abstract keyword to create an abstract class
    // it is not possible to create a new object (instantiate) from an abstract class
    // abstract classes can define implementations that derived classes inherit
    // abstract classes can define abstract methods _without_ implementation which derived classes _must_ implement
    internal abstract class Shape
    {
        // abstract classes can contain implementations for field/properties
        protected int XPosition { get; set; }
        protected int YPosition { get; set; }

        // abstract classes can contain abstract properties which must be implemented in derived classes
        public abstract double Area { get; }

        protected Shape(int xPostion, int yPosition)
        {
            XPosition = xPostion;
            YPosition = yPosition;
        }

        // abstract classes can contain methods with implementations
        public void DisplayPosition()
        {
            Console.WriteLine($"Current position: {XPosition}, {YPosition}");
        }

        // abstract classes can contain abstract methods with implemetation which must be implemented in the derived class
        public abstract void Draw();
    }
}
