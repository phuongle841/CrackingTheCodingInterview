using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview.LeetCode150
{
    public class lengthOfLongestSubstring
    {
        public static int LengthOfLongestSubstring(string s)
        {
            HashSet<char> map = new HashSet<char>();
            int left = 0;
            int max = 0;

            for (int i = 0; i < s.Length; i++)
            {
                while (map.Contains(s[i]))
                {
                    map.Remove(s[left]);
                    left++;
                }
                map.Add(s[i]);
                max = Math.Max(max, i - left + 1);
            }

            return max;
        }
    }
}
