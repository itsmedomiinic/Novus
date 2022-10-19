using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program:isPalindrome
    {
        static void Main(string[] args)
        {
            isPalindrome check = new isPalindrome();

            Console.WriteLine("Enter a String: ");
            String text = Console.ReadLine();

            bool palin = check.palindromCheck(text);

            if (palin == true)
            {
                Console.WriteLine("VALID PALINDROME");
            }
            else
            {
                Console.WriteLine("NOT A PALINDROME");
            }
            Console.ReadLine();
        }

        
    }
}
