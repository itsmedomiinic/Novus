using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Reversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            String str = Console.ReadLine();
            char[] chaArray = str.ToCharArray();

            int i = 0;
            int j = chaArray.Length-1;

            while (i < j)
            {
                char temp = chaArray[i];
                chaArray[i] = chaArray[j];
                chaArray[j] = temp;

                i++;
                j--;
            }

            Console.WriteLine("The reverse string is: ");
            foreach (char ch in chaArray)
            {
                Console.Write(ch);
            }
            Console.ReadLine();
        }
    }
}
