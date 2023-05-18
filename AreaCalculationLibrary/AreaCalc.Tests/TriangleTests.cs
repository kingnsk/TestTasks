using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalc.Tests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(15.0, 8.0, 17.0, 60.0)]
        public void AreaCalcTest(double a, double b, double c, double expectedArea)
        {
           var triangle = new Triangle(a,b,c);
            Assert.Equal(expectedArea, triangle.Area);

        }

        [Theory]
        [InlineData(6.0, 8.0, 10.0, true)]
        [InlineData(12.0, 12.0, 12.0, false)]
        public void IsRightTriangleTest(double a, double b, double c, bool isRigtTriangle)
        {
            var triangle = new Triangle(a, b, c);
            Assert.Equal(triangle.IsRightTriangle, isRigtTriangle);
        }

        [Theory]
        [InlineData(6.0, 8.0, 77.0)]
        public void IsNotTriangleThrowExceptionTest(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(a,b,c));
        }

        [Theory]
        [InlineData(6.0, 8.0, -10.0)]
        [InlineData(6.0, -8.0, 10.0)]
        [InlineData(-6.0, 8.0, 10.0)]
        public void NegativeLenghtSideThrowExceptionTest(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
        }


    }
}
