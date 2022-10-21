using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Next_Prime_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            choice++;

            for (int i = 2; i < choice; i++)
            {
                if (choice % i == 0)
                {
                    choice++;
                    i = 2;
                }
            }
            Console.WriteLine($"The next prime number is {choice}");

            Console.ReadLine();
        }
    }
}
