namespace CrackingTheCodingInterview.LeetCode150
{
    public class rob
    {
        public static int Rob(int[] nums)
        {
            int[] memo = new int[nums.Length];
            Array.Fill(memo, -1);
            int result = DP(nums, 0, memo);
            return result;
        }

        private static int DP(int[] nums, int index, int[] memo)
        {
            if (index >= nums.Length)
            {
                return 0;
            }
            if (memo[index] != -1)
            {
                return memo[index];
            }

            int rob = nums[index] + DP(nums, index + 2, memo);
            int skip = DP(nums, index + 1, memo);

            memo[index] = Math.Max(rob, skip);

            return memo[index];
        }

    }
}