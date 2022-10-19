using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number1_99
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int guess = 0;

            int ranNum = random.Next(1,99);

            Console.WriteLine($"The number is{ranNum}");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Guess the number?: ");
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess > ranNum)
                {
                    Console.WriteLine("LOWER");
                    //Console.WriteLine("Guess the number?: ");
                    //guess = Convert.ToInt32(Console.ReadLine());
                }
                else if (guess < ranNum)
                {
                    Console.WriteLine("HIGHER");
                }
                else
                {
                    Console.WriteLine($"CONGRATULATIONS THE ANSWER WAS {ranNum}");
                }
            }

            Console.WriteLine("THE GAME IS FINISHED");
            Console.ReadLine();

        }
    }
}
