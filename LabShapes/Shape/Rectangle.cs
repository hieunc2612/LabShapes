using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapelabD6
{
    internal class Rectangle:Shape
    {
        private int height, width;

        public int Height { get; private set; }
        public int Width { get; private set; }
        public Rectangle(int height, int width)
        {
            this.Height = height;
            this.Width = width;
        }
        public override double CalculatePerimeter()
        {
            return 2 * (height + width);
        }

        public override double CalculateArea()
        {
            return height * width;
        }
        public override string Draw()
        {
            return "Drawing a rectangle";
        }
    }
}
