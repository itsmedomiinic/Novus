using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Areas_Program
{
    class Triangle
    {
        public double Area(double sideA, double sideB, double sideC)
        {
            double S = (sideA + sideB + sideC) / 2;

            return Math.Sqrt(S * (S - sideA) * (S - sideB) * (S - sideC)); //herons formula
        }

        public double Perimeter(double sideA, double sideB, double sideC)
        {
            return sideA + sideB + sideC;
        }
    }
}
