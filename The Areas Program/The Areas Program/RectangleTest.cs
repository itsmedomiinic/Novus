using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace The_Areas_Program
{
    [TestFixture]
    class RectangleTest
    {
        [Test]
        public void AreaTest()
        {
            Rectangle r = new Rectangle();
            double x = 15.0;
            double y = 10.0;

            double expectedValue = 150.0;
            double actualValue = r.Area(x, y);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void PerimeterTest()
        {
            Rectangle r = new Rectangle();
            double x = 15.0;
            double y = 10.0;

            double expectedValue = 50.0;
            double actualValue = r.Perimeter(x, y);

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
