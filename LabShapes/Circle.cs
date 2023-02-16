using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabShapes
{
    internal class Circle : Shapes
    {
        public double radius { get; set; }
        public  Circle(double radius)
        {
            this.radius = radius;
        }
        public override double CalculatePerimeter() 
        {
            return 3.14 * radius * 2;
        }
        public override double CalculateArea() 
        {
            return radius * radius * 3.14;
        }

        public override string Draw()
        {
            return $"Draw the Circle";
        }
    }
}
