using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sales = { 1, 2, 1, 1, 0, 3, 1, 0, 0, 2, 4, 1, 0, 0, 0, 0, 2, 1, 0, 3, 1, 0, 0, 0, 6, 1, 3, 0, 0, 0 };

            int currentSequence = 0;

            int longestSequence = 0;

            for (int i = 0; i<sales.Length; i++)
            {
                currentSequence++;

                if (sales[i] != 0)
                {
                    currentSequence = 0;
                }

                if (currentSequence > longestSequence)
                {
                    longestSequence = currentSequence;
                }
            }

            Console.WriteLine($"The longest sequence of days without a sale is {longestSequence}");
            Console.ReadLine();
        }
    }
}
