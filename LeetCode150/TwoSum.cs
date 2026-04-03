namespace CrackingTheCodingInterview.LeetCode150
{
    public class twoSum
    {
        public static int[] TwoSum(int[] nums, int target)
        {

            Dictionary<int, int> dic = new();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (dic.ContainsKey(complement))
                {
                    return [dic[complement], i];
                }
                dic[nums[i]] = i;
            }

            return [];
        }
    }
}
