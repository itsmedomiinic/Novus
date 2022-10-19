using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String1
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public String helloName(String name)
        {
            return "Hello " + name;
        }

        public String makeAbba(String a, String b)
        {
            return a + b + b + a;
        }
        public String makeTags(String tag, String word)
        {
            return $"<{tag}>{word}<{tag}>";
        }

        public String makeOutWord(String outer, String word)
        {
            String sub1, sub2;
            sub1 = outer.Substring(0, 1);
            sub2 = outer.Substring(2, 3);

            return sub1 + word + sub2;
        }
    }
}
