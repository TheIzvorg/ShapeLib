using System;

namespace ShapeLib
{
    public class Triangle : Shape
    {
        private double _eageA, _eageB, _eageC;
        public bool IsRight => Math.Pow(_eageC,2) == Math.Pow(_eageA,2) + Math.Pow(_eageB,2);
        public Triangle(double EageA, double EageB, double EageC)
        {
            _eageA = EageA;
            _eageB = EageB;
            _eageC = EageC;
        }
        public override double GetArea()
        {
            double semip = GetPerimeter() / 2;
            double result = semip * (semip - _eageA) * (semip - _eageB) * (semip - _eageC);
            return Math.Sqrt(result);
        }

        public override double GetPerimeter()
        {
            return _eageA + _eageB + _eageC;
        }
    }
}
