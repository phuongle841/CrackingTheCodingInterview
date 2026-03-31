using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview.LeetCode150
{
    public class coinChange
    {
        public static int CoinChange(int[] coins, int amount)
        {
            int[] memo = new int[amount + 1];
            Array.Fill(memo, -1);
            int result = DP(coins, amount, memo);

            return result != int.MaxValue ? result : -1;
        }

        private static int DP(int[] coins, int amount, int[] memo)
        {


            if (amount < 0)
                return int.MaxValue;
            if (amount == 0)
                return 0;

            if (memo[amount] != -1)
            {
                return memo[amount];
            }

            int min = int.MaxValue;

            for (int i = 0; i < coins.Length; i++)
            {
                int currentMin = DP(coins, amount - coins[i], memo);
                if (currentMin != int.MaxValue)
                {
                    min = Math.Min(currentMin + 1, min);
                }
            }

            memo[amount] = min;
            return memo[amount];
        }

    }
}
