using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalc.Tests
{
    public class CircleTests
    {

        [Theory]
        [InlineData(10.0)]
        [InlineData(1.0)]
    
        public void AreaCalcTest(double radius)
        {
            var circle = new Circle(radius);
            var expectedArea = Math.PI*Math.Pow(radius,2.0);
            Assert.Equal(expectedArea, circle.Area);
        }

        [Theory]
        [InlineData(-100)]
        public void NegativeRadiusThrowExceptionTest(double radius)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(radius));
        }
    
    }
}
