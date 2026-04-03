using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview.LeetCode150
{
    public class twoSumII
    {
        public static int[] TwoSum(int[] numbers, int target)
        {
            int left = 0, right = numbers.Length - 1;
            while (left < right)
            {
                int currSum = numbers[left] + numbers[right];
                if (currSum == target)
                    return new int[] { left + 1, right + 1 };
                if (currSum > target)
                    right--;
                else
                    left++;
            }
            return new int[] { };
        }
    }
}
