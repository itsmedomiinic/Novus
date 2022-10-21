using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sequence of integers: ");
            int integ = Convert.ToInt32(Console.ReadLine());

            
            int sum = 0;
            while (integ != 0)
            {
                sum += integ % 10;
                integ /= 10;
            }
            

            //int sum = integ.ToString().Sum(c => c - '0');

            Console.WriteLine($"The sum is {sum}");
            Console.ReadLine();
        }
    }
}
