using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Geometry
{
    class Square: Rectangle
    {
        public Square(double length) : base(length, length)
        {

        }
----------------------------------------------------
double CalculateArea();
        double CalculatePerimeter();
--------------------------------------------------------
Rectangle rectangle = new Rectangle(6, 5);
        Square square = new Square(10);
        Circle circle = new Circle(7);

        IShape[] shapes = { rectangle, square, circle };

            foreach (IShape shape in shapes)
            {
                Console.WriteLine(shape.CalculateArea());
                Console.WriteLine(shape.CalculatePerimeter());

            }
}
}
