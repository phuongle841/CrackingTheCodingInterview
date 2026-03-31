using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview.LeetCode150
{
    public class climbStairs
    {
        public static int ClimbStairs(int n)
        {
            int[] memo = new int[n];
            Array.Fill(memo, -1);

            int result = DP(n, 0, memo);

            return result;
        }

        private static int DP(int n, int index, int[] memo)
        {
            if (index == n)
            {
                return 1;
            }
            if (index>n)
            {
                return 0;
            }

            if (memo[index] != -1)
            {
                return memo[index];
            }

            int oneStep = DP(n, index + 1, memo);
            int twoSteps = DP(n, index + 2, memo);
            memo[index] = oneStep + twoSteps;
            return memo[index];
        }

    }
}
