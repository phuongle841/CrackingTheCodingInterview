using System;
using System.Collections.Generic;

namespace CrackingTheCodingInterview.LeetCode150
{
    public class twoSum
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int curr = 0;

            for (int i = 0; i < nums.Length; i++)
            {

                curr = target - nums[i];
                if (dic.ContainsKey(curr))
                {
                    return new int[] { dic[curr], i };
                }
                dic[nums[i]] = i;
            }

            return new int[0];
        }
    }
}
