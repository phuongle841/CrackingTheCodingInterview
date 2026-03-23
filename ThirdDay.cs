public class ThirdDay
{
    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();

        Dictionary<char, char> dic = new Dictionary<char, char>()
        {
            { ')' , '(' },
            { ']' , '[' },
            { '}' , '{' }

        };
        foreach (char i in s)
        {
            if (dic.ContainsValue(i))
            {
                stack.Push(i);
            }
            else if (dic.ContainsKey(i))
            {
                if (stack.Count == 0 || stack.Peek() != dic[i])
                {
                    return false;
                }
                stack.Pop();
            }
        }

        return stack.Count == 0;
    }
    public int MinCostClimbingStairs(int[] cost)
    {
        int prev2 = cost[0];
        int prev1 = cost[1];

        for (int i = 2; i < cost.Length; i++)
        {
            int curr = cost[i] + Math.Min(prev2, prev1);
            prev2 = prev1;
            prev1 = curr;
        }
        return Math.Min(prev2, prev1);
    }

}

public static class StringExtenstion
{
    public static bool StringExtension(this string s)
    {
        return s.Length > 5;
    }
}