using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace The_Areas_Program
{
    [TestFixture]
    class CircleTest
    {
        [Test]
        public void AreaTest()
        {
            Circle c = new Circle();
            double x = 15.0;

            double expectedValue = 150.0;
            double actualValue = c.Area(x);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void PerimeterTest()
        {
            Circle c = new Circle();
            double x = 15.0;

            double expectedValue = 50.0;
            double actualValue = c.Perimeter(x);

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
