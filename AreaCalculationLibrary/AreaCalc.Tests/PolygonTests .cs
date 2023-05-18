using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalc.Tests
{
    public class PolygonTests
    {
        [Fact]
        public void AreaCalcTest()
        {
            var polygon = new Polygon(
                new Vector2(0,0),
                new Vector2(10, 0),
                new Vector2(10, 10),
                new Vector2(0, 10)
                );
            Assert.Equal(100,polygon.Area);
        }
    
    }
}
