using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalc
{
    public class Triangle : Shape
    {
        public const double accuracy = 1e-6;

        public double[] Sides;
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        private Lazy<bool> _isRightTriangle;
        public bool IsRightTriangle => _isRightTriangle.Value;

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;

            if(SideA <= 0.0 || SideB <= 0.0 || SideC <= 0.0)
            {
                throw new ArgumentException("Длина стороны треугольника должны быть больше 0");
            }
            else if (SideA + SideB < SideC || SideB + SideC < SideA || SideA + SideC < SideB)
            {
                throw new ArgumentException("Стороны не образуют треугольник");
            }

            Sides = new double[3] {SideA, SideB, SideC};
            _isRightTriangle = new Lazy<bool>(GetIsRightTriangle);
        }

        public bool GetIsRightTriangle()
        {
            Array.Sort(Sides);
            return Math.Abs(Math.Pow(Sides[0], 2) + Math.Pow(Sides[1], 2) - Math.Pow(Sides[2],2)) <= accuracy;
        }

        protected override double CalculateArea()
        {
            var p = (SideA + SideB + SideC) / 2d;
            var area = Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
            return area;
        }
    }
}
