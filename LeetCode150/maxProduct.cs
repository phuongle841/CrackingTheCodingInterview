using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview.LeetCode150
{
    public class maxProduct
    {
        public static int MaxProduct(int[] nums)
        {
            int currentMax = nums[0];
            int maxProduct = nums[0];
            int minProduct = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                int temp = currentMax;
                currentMax = Math.Max(Math.Max(temp * nums[i], minProduct * nums[i]), nums[i]);

                minProduct = Math.Min(Math.Min(temp * nums[i], minProduct * nums[i]), nums[i]);
                maxProduct = Math.Max(currentMax, maxProduct);
            }

            return maxProduct;
        }
    }
}
