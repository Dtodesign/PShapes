using System;
namespace polymorphismShapes
{
    class Rectangle : Shape
    {
        private double Length { get; set; }
        private double Width { get; set; }

        public Rectangle()
        {
        }
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override double CalculateArea()
        {
            double area = this.Length * this.Width;
            return area;
        }

        public override double CalculatePerimeter()
        {
            double prim = (double)(2 * (Length + Width));
            return prim;
        }
    }
}
