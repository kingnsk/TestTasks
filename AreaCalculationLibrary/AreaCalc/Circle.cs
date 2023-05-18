using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalc
{
    public class Circle : Shape
    {
        public double Radius { get; }

        public Circle(double radius) 
        { 
            if (radius <= 0.0) 
            {
                throw new ArgumentOutOfRangeException("Радиус должен быть больше 0");
            }
            Radius = radius;
        }
        protected override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2d);
        }
    }
}
