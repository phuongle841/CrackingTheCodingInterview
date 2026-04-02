using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview.LeetCode150
{
    public class maxProfit
    {
        public static int MaxProfit(int[] prices)
        {
            int min = int.MaxValue, profit = 0;

            for (int i = 0; i < prices.Length; i++)
            {

                profit = Math.Max(prices[i] - min, profit);
                if (min > prices[i])
                {
                    min = prices[i];
                }
            }

            return profit;
        }
    }
}
