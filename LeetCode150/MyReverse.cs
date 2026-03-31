using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview.LeetCode150
{
    internal class MyReverse
    {
        public static int Reverse(int x)
        {
            int rev = 0;
            while (x != 0)
            {
                int digit = x % 10;
                x /= 10;
                if ((rev > 0 && rev > (int.MaxValue - digit) / 10) || (rev < 0 && rev < (int.MinValue - digit) / 10)) 
                {
                    return 0;
                }
                rev = rev * 10 + digit;
            }

            return rev;
        }
    }
}
