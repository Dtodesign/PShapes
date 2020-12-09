using System;
namespace polymorphismShapes
{
     class Triangle : Shape
    {
        public double trSide { get; set; }
        public double trHeight { get; set; }
        public double  trSid { get; set; }


        public Triangle()
        {
        }
        public Triangle(double trside, double trheight)
        {
            trSide = trside;
            trHeight = trheight;
        }
        public Triangle(double trside, double trheight, double trsid)
        {
            trSide = trside;
            trHeight = trheight;
            trSid = trsid;
        }
        public override double CalculateArea()
        {
            double area = (trSide * trHeight) / 2;
            return area;
        }

        public override double CalculatePerimeter()
        {
            double prim = (double)trSid + trSide + trHeight;
            return prim;
        }
    }
}
