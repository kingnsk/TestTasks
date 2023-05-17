using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalc
{
    public class Polygon : Shape
    {
        public List<Vector2> Points;

        public Polygon(params Vector2[] dots)
        {
            Points = dots.ToList();
        }
        protected override double CalculateArea()
        {
            double area = 0.0;
            for (int i = 0; i < Points.Count-1; i++)
            {
                area += Points[i].X * Points[i + 1].Y - Points[i].Y * Points[i + 1].X;
            }
            area += Points[Points.Count - 1].X * Points[0].Y - Points[Points.Count - 1].Y * Points[0].X;

            return Math.Abs(area) / 2;
        }
    }
}
