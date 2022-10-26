using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace The_Areas_Program
{
    [TestFixture]
    class TriangleTest
    {
        [Test]
        public void AreaTest()
        {
            Triangle t = new Triangle();
            double x = 15.0;
            double y = 10.0;
            double z = 15.0;

            double expectedValue = 150.0;
            double actualValue = t.Area(x, y, z);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void PerimeterTest()
        {
            Triangle t = new Triangle();
            double x = 15.0;
            double y = 10.0;
            double z = 15.0;

            double expectedValue = 40.0;
            double actualValue = t.Perimeter(x, y, z);

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
