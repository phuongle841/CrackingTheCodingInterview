namespace CrackingTheCodingInterview.LeetCode150
{
    public class productExceptSelf
    {
        public static int[] ProductExceptSelf(int[] nums)
        {
            int[] result = new int[nums.Length];
            Array.Fill(result, 1);
            int fix = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = fix;
                fix *= nums[i];
            }
            fix = 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                result[i] = fix * result[i];
                fix = fix * nums[i];
            }

            return result;
        }
    }
}
