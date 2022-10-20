using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams
{
    class Program:sortStringClass
    {
        static void Main(string[] args)
        {
            sortStringClass sort = new sortStringClass();

            String[] dictionary = { "parts", "traps", "arts", "rats", "starts", "tarts", "rat", "art", "tar", "tars", "stars", "stray" };
            List<String> anagrams = new List<String>();

            String target = sort.SortString("star");

            String word = "";
            int counter = 0;

            for (int i = 0; i<dictionary.Length; i++)
            {
                word = sort.SortString(dictionary[i]);

                if (word == target)
                {
                    anagrams.Add(dictionary[i]);
                }
            }

            Console.WriteLine("The anagrams of 'star' are: ");
            anagrams.ForEach(Console.WriteLine);

            Console.ReadLine();
        }


    }
}
