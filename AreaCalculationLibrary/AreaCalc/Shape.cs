using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalc
{
    public abstract class Shape
    {
        private readonly Lazy<double> _area;
        public double Area => _area.Value;

        protected Shape() => _area = new Lazy<double>(CalculateArea);

        protected abstract double CalculateArea();
    }
}
