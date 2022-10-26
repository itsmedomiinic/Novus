using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Areas_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            Rectangle r = new Rectangle();
            Triangle t = new Triangle();

            double x = 10;
            double y = 20;
            double z = 30;

            Console.WriteLine($"The area of the circle is: {c.Area(x)} ");
            Console.WriteLine($"The perimeter of the circle is: {c.Perimeter(x)} ");

            Console.WriteLine($"The area of the triangle is: {t.Area(x,y,z)} ");
            Console.WriteLine($"The perimeter of the triangle is: {t.Perimeter(x,y,z)} ");

            Console.WriteLine($"The area of the rectangle is: {r.Area(x,y)} ");
            Console.WriteLine($"The perimeter of the rectangle is: {r.Perimeter(x,y)} ");

            Console.ReadLine();
        }
    }
}
