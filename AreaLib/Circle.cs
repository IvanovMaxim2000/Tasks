using System;

namespace AreaLib
{
    public class Circle : IFigure
    {
        private double _radius;

        public Circle(double radius)
        {
            if (radius < 0) throw new Exception("Invalid radius");
            _radius = radius;
        }

        public double GetArea() => Math.PI * Math.Pow(_radius, 2);
    }
}
