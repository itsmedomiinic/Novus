using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Areas_Program
{
    class Rectangle
    {
        public double Area(double height, double width)
        {
            return height * width;
        }
        public double Perimeter(double height, double width)
        {
            return 2 * height + 2 * width;
        }
    }
}
