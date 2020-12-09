using System;
namespace polymorphismShapes
{
     class Square : Shape
    {
        private double Side { get; set; }
        

        public Square()
        {
        }
        public Square(double side)
        {
            Side = side;
           
        }

        public override double CalculateArea()
        {
            double area = Side * Side;
            return area;
        }

        public override double CalculatePerimeter()
        {
            double Prim = 4 * Side;
            return Prim;
        }
    }
}
