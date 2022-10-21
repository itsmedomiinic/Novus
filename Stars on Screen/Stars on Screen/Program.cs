using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stars_on_Screen
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = "*";

            //String[] space = {" ", " ", " "};

            String space = "     "; //5 spaces

            //space = space.Remove(0, 1);
            //Console.WriteLine(space);

            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(space+s);
                s = s + "**";
                space = space.Remove(0, 1);
            }
            
            Console.ReadLine();
        }
    }
}
