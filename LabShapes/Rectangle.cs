using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabShapes
{
    internal class Rectangle : Shapes
    {
        public double width { get; set; }
        public double height { get; set; }

        public  Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double CalculatePerimeter()
        {
            return (width + height) * 2;
        }
        public override double CalculateArea()
        {
            return width * height;
        }

        public override string Draw()
        {
            return $"Draw the Retangle";
        }
    }
}
