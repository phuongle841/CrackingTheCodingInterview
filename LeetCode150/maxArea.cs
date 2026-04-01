using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview.LeetCode150
{
    public class maxArea
    {
        public static int MaxArea(int[] height)
        {
            int left = 0, right = height.Length - 1, max = 0;

            while (left != right)
            {
                int curHeight = Math.Min(height[right], height[left]);
                max = Math.Max((right - left) * (curHeight), max);

                if (height[left] > height[right])
                    right--;
                else
                    left++;
            }
            return max;
        }
    }
}