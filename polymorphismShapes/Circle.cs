using System;
namespace polymorphismShapes
{
   class Circle : Shape
    {
        private double Radius { get; set; }
        public Circle()
        {
        }
        public Circle(double r)
        {
            Radius = r;
        }

        public override double CalculateArea()
        {
            double area = (double)(Math.Pow(this.Radius, 2) * Math.PI);
    
            return area;
                
        }

        public override double CalculatePerimeter()
        {
            double prim = (double)(2 * Radius * Math.PI);
            return prim;
        }
    }
}
