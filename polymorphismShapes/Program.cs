using System;

namespace polymorphismShapes
{
    class Program
    {
        static void Main(string[] args)
        {

            
          
            //Circle circle = new Circle(x);
           

           

            bool exit = false;
            string option;

            // myVec.DisplayInfo();

            while (!exit)
            {
                Console.WriteLine("Choose a Shape to Calculate Area & Primeter: ");
                Console.WriteLine("\t1 - Circle");
                Console.WriteLine("\t2 - Square");
                Console.WriteLine("\t3 - Rectangle");
                Console.WriteLine("\t4 - Triangle");
                Console.WriteLine("\t5 - Exit");
                Console.Write("Your option? ");

                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.WriteLine("Circle Area:\n");
                        Console.WriteLine("Enter a number for Radius:\n");

                        double radius = Convert.ToInt32(Console.ReadLine());
                        Circle circle = new Circle(radius);
                        Console.WriteLine("Area of circle: {0} ", circle.CalculateArea());
                        Console.WriteLine("Primeter of circle: {0} ", circle.CalculatePerimeter());
                        Console.WriteLine("-----------------");
                        break;
                    case "2":
                        Console.WriteLine("Square Area:\n");

                        Console.WriteLine("Enter a Number for Length of Side:\n");

                        double side = Convert.ToInt32(Console.ReadLine());

                        Square square = new Square(side);
                        Console.WriteLine("Area of square: {0} ", square.CalculateArea());
                        Console.WriteLine("primeter of square: {0} ", square.CalculatePerimeter());
                        Console.WriteLine("-----------------");
                        break;
                    case "3":
                        Console.WriteLine("Rectangle Area:\n");

                        Console.WriteLine("Enter a Number for Length:\n");
                        double len = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter a Number for Length:\n");
                        double wid = Convert.ToInt32(Console.ReadLine());

                        Rectangle rectangle = new Rectangle(len,wid);
                        Console.WriteLine("Area of Rectangle: {0} ", rectangle.CalculateArea());
                        Console.WriteLine("Primetere of Rectangle: {0} ", rectangle.CalculatePerimeter());
                        Console.WriteLine("-----------------");
                        break;
                    case "4":
                        Console.WriteLine("Triangle Area:\n");

                        Console.WriteLine("Enter a Number for Triangle Base Length:\n");
                        double b = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter a Number for Triangle Height Length:\n");
                        double h = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter a Number for Triangle Side Length:\n");
                        double s = Convert.ToInt32(Console.ReadLine());

                        Triangle triangle = new Triangle(b, h);
                        Triangle tr = new Triangle(b, h, s);
                        Console.WriteLine("Area of Triangle: {0} ", triangle.CalculateArea());
                        Console.WriteLine("Primeter of Triangle: {0} ", tr.CalculatePerimeter());
                        Console.WriteLine("-----------------");
                        break;
                        case "5":
                             Environment.Exit(1);
                              break;

                }
                Console.Write("Press 'e' and Enter to Exit the app, or press Enter to Continue \n");
                if (Console.ReadLine() == "e") exit = true;

                Console.WriteLine("\n");
            }
        }
    }
}
