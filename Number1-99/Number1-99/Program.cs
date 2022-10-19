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

            //to test the game
            Console.WriteLine($"The number is {ranNum}");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Guess the number?: ");
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess > ranNum)
                {
                    Console.WriteLine("LOWER");
                }
                else if (guess < ranNum)
                {
                    Console.WriteLine("HIGHER");
                }
                else
                {
                    Console.WriteLine($"CONGRATULATIONS THE ANSWER WAS {ranNum} \n");
                    break;
                }
            }
            Console.WriteLine("THE GAME IS NOW FINISHED");
            Console.ReadLine();
        }
    }
}
