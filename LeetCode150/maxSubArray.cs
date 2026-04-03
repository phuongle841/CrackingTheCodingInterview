namespace CrackingTheCodingInterview.LeetCode150
{
    public class maxSubArray
    {
        public static int MaxSubArray(int[] nums)
        {
            int currentSum = 0;
            int maxSum = int.MinValue;

            foreach (var item in nums)
            {
                currentSum = Math.Max(item, currentSum + item);
                maxSum = Math.Max(maxSum, currentSum);
            }

            return maxSum;
        }
    }
}
