using System;
namespace polymorphismShapes
{
    abstract class Shape
    {
        //public int Width { get; set; }
        //public int Height { get; set; }
        //public int X { get; set; }
        //public int Y { get; set; }

        public Shape()
        {
        }

        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();
        
    }
}
