using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stars_on_Screen_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            int space = 4;
            for (int i = 1; i <= 5; i++)
            {
                for (int k = 1; k <= space; k++)
                {
                    Console.Write(" ");   
                }
                space--;
                for (int j = 1; j <= i*2-1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
