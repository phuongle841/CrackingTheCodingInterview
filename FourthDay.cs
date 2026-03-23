public class FourthDay
{
    public int LengthOfLongestSubstring(string s)
    {
        HashSet<int> set = new();
        int left = 0, max = 0;

        for (int i = 0; i < s.Length; i++)
        {
            while (set.Contains(s[i]))
            {
                set.Remove(s[left]);
                left++;
            }
            set.Add(s[i]);
            max = Math.Max(max, i - left + 1);
        }

        return max;

    }
}