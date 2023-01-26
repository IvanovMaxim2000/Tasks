using System;
using System.Collections.Generic;
using System.Text;

namespace AreaLib
{
    public class Triangle : IFigure
    {
        private double _sideA, _sideB, _sideC;
        private double _maxSide;
        private double[] _anotherSides = new double[2];

        public Triangle(double sideA, double sideB, double sideC)
        {
            if ((sideA <= 0) || (sideB <= 0) || (sideC <= 0)) throw new Exception("Invalid values of sides");

            if (Math.Max(sideA, Math.Max(sideB, sideC)) == sideA)
            {
                _maxSide = sideA;
                _anotherSides[0] = sideB;
                _anotherSides[1] = sideC;
            }
            if (Math.Max(sideA, Math.Max(sideB, sideC)) == sideB)
            {
                _maxSide = sideB;
                _anotherSides[0] = sideA;
                _anotherSides[1] = sideC;
            }
            else
            {
                _maxSide = sideC;
                _anotherSides[0] = sideA;
                _anotherSides[1] = sideB;
            }

            if (_maxSide > _anotherSides[0] + _anotherSides[1]) throw new Exception("Max side of the triangle must be less than sum of two another");

            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public bool isRightTriangle => GetIsRightTriangle();

        private bool GetIsRightTriangle()
        {
            return Math.Pow(_anotherSides[0], 2) + Math.Pow(_anotherSides[1], 2) == Math.Pow(_maxSide, 2);
        }

        public double GetArea()
        {
            double halfPer = (_sideA + _sideB + _sideC) / 2;
            double res = Math.Sqrt(halfPer * (halfPer - _sideA) * (halfPer - _sideB) * (halfPer - _sideC));
            return res;
        }
    }
}
