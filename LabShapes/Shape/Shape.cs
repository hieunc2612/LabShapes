using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapelabD6
{
    internal abstract class Shape
    {
        public abstract double CalculatePerimeter();
        public abstract double CalculateArea();
        //public virtual string Draw() 
        //{
        //    return$"Perimeter:{CalculatePerimeter} Area: {CalculateArea}";
        //}
        public virtual string Draw()
        {
            return "Drawing Shape...";
        }
    }
}
