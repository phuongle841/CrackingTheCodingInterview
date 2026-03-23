using System.Collections;

public class FirstDay
{
    public class person
    {
        private int id;

        public string name
        {
            get; set;
        }
    }

    public void ReverseString(char[] input)
    {
        int left = 0;
        int right = input.Length - 1;

        while (left < right)
        {
            char temp = input[left];
            input[left] = input[right];
            input[right] = temp;
            left++;
            right--;
        }
    }
    public int FindKthLargest(int[] nums, int k)
    {
        PriorityQueue<int, int> queue = new();

        foreach (var item in nums)
        {
            queue.Enqueue(item, item);
            if (queue.Count > k)
            {
                queue.Dequeue();
            }
        }
        return queue.Peek();
    }
    public int MaxFrequencyElements(int[] nums)
    {
        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();
        int max = 0;
        int maxFrequence = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            int value = nums[i];

            if (!frequencyMap.ContainsKey(nums[i]))
            {
                frequencyMap.Add(nums[i], 0);
            }
            frequencyMap[nums[i]]++;
        }

        foreach (KeyValuePair<int, int> kvp in frequencyMap)
        {
            maxFrequence = Math.Max(maxFrequence, kvp.Value);
        }

        foreach (var item in frequencyMap)
        {
            if (item.Value == maxFrequence)
            {
                max += maxFrequence;
            }
        }

        return max;
    }

    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int completment = target - nums[i];
            if (map.ContainsKey(completment))
            {
                return [i, map[completment]];
            }
            map[nums[i]] = i;
        }

        return new int[0];
    }

    public bool IsPalindrome(string s)
    {
        int left = 0, right = s.Length;

        while (left < right)
        {
            while (left < right && !char.IsLetterOrDigit(s[left]))
            {
                left++;
            }
            while (left < right && !char.IsLetterOrDigit(s[right - 1]))
            {
                right--;
            }
            if (left < right && char.ToLower(s[left]) != char.ToLower(s[right - 1]))
            {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }

}
