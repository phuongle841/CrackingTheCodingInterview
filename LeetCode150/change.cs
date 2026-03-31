using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview.LeetCode150
{
    internal class change
    {
        public static int Change(int amount, int[] coins)
        {
            int[,] dp = new int[coins.Length, amount + 1];

            dp[0, 0] = 0;

            return 1;
        }

        private static int DP(int amount, int[] coins, int[,] memo)
        {



            return amount;
        }
    }
}
