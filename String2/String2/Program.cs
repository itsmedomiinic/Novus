using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String2
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public String doubleChar(String str)
        {
            String result = "";

            for (int i = 0; i < str.Length; i++)
            {
                result = result + str[i];
                result = result + str[i];
            }
            return result;
        }

        public int countHi(String str)
        {
            for (int i = 0; i<str.Length; i++)
            {
                
            }
        }
    }
}
