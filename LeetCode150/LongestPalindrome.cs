using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview.LeetCode150
{
    public class longestPalindrome
    {
        public static string LongestPalindrome(string s)
        {
            if (s.Length == 0) return "";

            int start = 0;
            int maxLength = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int odd = ExpandAroundCenter(s, i, i);
                int even = ExpandAroundCenter(s, i, i + 1);

                int max = Math.Max(odd, even);

                if (max > maxLength)
                {
                    maxLength = max;
                    start = i - (maxLength - 1) / 2;
                }

            }

            return s.Substring(start, maxLength);
        }

        private static int ExpandAroundCenter(string s, int left, int right)
        {
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                right++;
                left--;
            }
            return right - left - 1;
        }

    }
}
