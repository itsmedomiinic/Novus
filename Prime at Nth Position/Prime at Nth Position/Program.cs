using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_at_Nth_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] primes = {2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61,
67, 71, 73, 79, 83, 89, 97 };

            Console.WriteLine("What position prime number do you want: ");

            int position = Convert.ToInt32(Console.ReadLine());

            if (position > 25)
            {
                Console.WriteLine("Please enter a number between 1 - 25");
            }
            else
            {
                Console.WriteLine($"Prime at {position}th position is " + primes[position - 1]);
            }
            Console.ReadLine();
        }
    }
}
