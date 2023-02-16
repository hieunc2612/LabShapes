using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabShapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(3);
            Rectangle rectangle = new Rectangle(4, 6);
            Console.WriteLine("Calculate the area of a circle:");
            Console.WriteLine(circle.CalculateArea());
            Console.WriteLine("Calculate the circumference of a circle:");
            Console.WriteLine(circle.CalculatePerimeter());
            Console.WriteLine(circle.Draw());
            Console.WriteLine("==========================================");
            Console.WriteLine("Calculate the area of a rectangle:");
            Console.WriteLine(rectangle.CalculatePerimeter());
            Console.WriteLine("Calculate the circumference of ​​a rectangle:");
            Console.WriteLine(rectangle.CalculateArea());
            Console.WriteLine(rectangle.Draw());
            Console.WriteLine("==========================================");

        }
    }
}
