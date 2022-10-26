using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Areas_Program
{
    class Circle
    {
        double pi = Math.PI;
        public double Area(double radius)
        {
            return pi * radius * radius;
        }
        public double Perimeter(double radius)
        {
            return 2 * pi * radius;
        }
    }
}
