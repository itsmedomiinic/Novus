using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public class isPalindrome
    {
        public bool palindromCheck(String text)
        {
            text.ToLower();
            text.Replace(" ", "");

            int j = text.Length;

            for (int i = 0; i < j / 2; i++)
            {
                if (text[i] != text[j - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
