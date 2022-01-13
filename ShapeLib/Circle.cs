using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLib
{
    public class Circle : Shape
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }
        public override double GetArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }

        public override double GetPerimeter()
        {
            return Math.PI * 2 * _radius;
        }
    }
}
