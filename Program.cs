// See https://aka.ms/new-console-template for more information

using CrackingTheCodingInterview.LeetCode150;
using static CrackingTheCodingInterview.LeetCode150.addTwoNumbers;

public class Program
{
    delegate void MessageDelegate(string message);

    public static async Task Main(string[] args)
    {
        ThreeSumTest();
    }

    private static void ThreeSumTest()
    {
        int[] nums = [-1, 0, 1, 2, -1, -4];
        IList<IList<int>> result = threeSum.ThreeSum(nums);
        for (int i = 0; i < result.Count; i++)
        {
            for (int j = 0; j < result[0].Count; j++)
            {
                Console.WriteLine(result[i][j]);
            }
        }
    }

    private static void TwoSumIITest()
    {
        int[] numbers = [2, 7, 11, 15];
        int target = 9;
        int[] result = twoSumII.TwoSum(numbers, target);
        Console.WriteLine("{0}", string.Join(", ", result));

        numbers = [2, 3, 4]; target = 6;
        result = twoSumII.TwoSum(numbers, target);
        Console.WriteLine("{0}", string.Join(", ", result));

        numbers = [-1, 0]; target = -1;
        result = twoSumII.TwoSum(numbers, target);
        Console.WriteLine("{0}", string.Join(", ", result));

    }

    private static void SearchTest()
    {
        int[] nums = [-1, 0, 3, 5, 9, 12];
        int target = 9;
        Console.WriteLine(search.Search(nums, target));

        nums = [-1, 0, 3, 5, 9, 12]; target = 2;
        Console.WriteLine(search.Search(nums, target));

    }

    private static void FindMinTest()
    {
        int[] nums = [3, 4, 5, 1, 2];
        Console.WriteLine(findMin.FindMin(nums));

        nums = [4, 5, 6, 7, 0, 1, 2];
        Console.WriteLine(findMin.FindMin(nums));

        nums = [11, 13, 15, 17];
        Console.WriteLine(findMin.FindMin(nums));
    }

    private static void MaxProductTest()
    {
        int[] nums = [2, 3, -2, 4];
        Console.WriteLine(maxProduct.MaxProduct(nums));

        nums = [-2, 0, -1];
        Console.WriteLine(maxProduct.MaxProduct(nums));

    }

    private static void MaxSubArrayTest()
    {
        int[] nums = [-2, 1, -3, 4, -1, 2, 1, -5, 4];
        Console.WriteLine(maxSubArray.MaxSubArray(nums));

        nums = [1];
        Console.WriteLine(maxSubArray.MaxSubArray(nums));

        nums = [5, 4, -1, 7, 8];
        Console.WriteLine(maxSubArray.MaxSubArray(nums));
    }

    private static void ProductExceptSelfTest()
    {
        int[] nums = [1, 2, 3, 4];
        Console.WriteLine("{0}", string.Join(", ", productExceptSelf.ProductExceptSelf(nums)));

        nums = [-1, 1, 0, -3, 3];
        Console.WriteLine("{0}", string.Join(", ", productExceptSelf.ProductExceptSelf(nums)));
    }

    private static void ConaintsDuplicateTest()
    {
        int[] nums = [1, 2, 3, 1];
        Console.WriteLine(containsDuplicate.ContainsDuplicate(nums));

        nums = [1, 2, 3, 4];
        Console.WriteLine(containsDuplicate.ContainsDuplicate(nums));

        nums = [1, 1, 1, 3, 3, 4, 3, 2, 4, 2];
        Console.WriteLine(containsDuplicate.ContainsDuplicate(nums));
    }

    private static void MaxProfitTest()
    {
        int[] prices = [7, 1, 5, 3, 6, 4];
        Console.WriteLine(maxProfit.MaxProfit(prices));
    }

    private static void TwoSumTest()
    {
        int[] nums = [2, 7, 11, 15];
        int target = 9;
        int[] result = twoSum.TwoSum(nums, target);
        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine(result[i]);
        }

        nums = [3, 2, 4];
        target = 6;
        result = twoSum.TwoSum(nums, target);
        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine(result[i]);
        }

        nums = [3, 3];
        target = 6;
        result = twoSum.TwoSum(nums, target);
        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine(result[i]);
        }
    }

    private static void OrangesRottingTest()
    {
        int[,] grid = new int[3, 3] {
            { 2, 1, 1 },
            { 1, 1, 0 },
            { 0, 1, 1 },
        };
        Console.WriteLine(orangesRotting.OrangesRotting(grid));
    }

    private static void MaxAreaTest()
    {
        int[] height = [1, 8, 6, 2, 5, 4, 8, 3, 7];
        Console.WriteLine(maxArea.MaxArea(height));
        height = [1, 1];
        Console.WriteLine(maxArea.MaxArea(height));
        height = [8, 7, 2, 1];
        Console.WriteLine(maxArea.MaxArea(height));

    }

    private static void goodNodesTest()
    {
        goodNodes.TreeNode root = new goodNodes.TreeNode(3);

        goodNodes.TreeNode two = new goodNodes.TreeNode(1);
        goodNodes.TreeNode three = new goodNodes.TreeNode(4);
        goodNodes.TreeNode four = new goodNodes.TreeNode(3);
        goodNodes.TreeNode five = new goodNodes.TreeNode(1);
        goodNodes.TreeNode six = new goodNodes.TreeNode(5);

        root.left = two;
        root.right = three;
        two.left = four;
        three.left = five;
        three.right = six;
        Console.Write(goodNodes.GoodNodes(root));
    }

    private static void MyReverseTest()
    {
        int testCase = 123;
        Console.WriteLine(MyReverse.Reverse(testCase));

        testCase = -123;
        Console.WriteLine(MyReverse.Reverse(testCase));

        testCase = 120;
        Console.WriteLine(MyReverse.Reverse(testCase));
    }

    private static void coinChangeTest()
    {
        int[] coins = [1, 2, 5];
        int amount = 11;
        Console.WriteLine(coinChange.CoinChange(coins, amount));
        coins = [2];
        amount = 3;
        Console.WriteLine(coinChange.CoinChange(coins, amount));
        coins = [1];
        amount = 0;
        Console.WriteLine(coinChange.CoinChange(coins, amount));
    }

    private static void ClimbStairsTest()
    {
        int n = 2;
        Console.WriteLine(climbStairs.ClimbStairs(n));
        n = 3;
        Console.WriteLine(climbStairs.ClimbStairs(n));
    }

    static void RobTest()
    {
        int[] nums = [1, 2, 3, 1];
        Console.WriteLine(rob.Rob(nums));
        nums = [2, 7, 9, 3, 1];
        Console.WriteLine(rob.Rob(nums));
    }

    static void ChangeTest()
    {
        int amount = 5;
        int[] coins = [1, 2, 5];
        Console.WriteLine(change.Change(amount, coins));
    }

    static void LongestPalidromeTest()
    {
        string testCase = "baba";
        Console.WriteLine("Longest Palindrome of \"{0}\" is: {1}", testCase, longestPalindrome.LongestPalindrome(testCase));
    }

    public static void FindMedianSortedArraysTest()
    {
        var findMedianSortedArrays = new findMedianSortedArrays();
        int[] nums1 = [1, 3];
        int[] nums2 = [2];
        Console.WriteLine(findMedianSortedArrays.FindMedianSortedArrays(nums1, nums2));
        nums1 = [1, 2];
        nums2 = [3, 4];
        Console.WriteLine(findMedianSortedArrays.FindMedianSortedArrays(nums1, nums2));
    }

    public static void LengthOfLongestSubstringTest2()
    {
        string testCase = "abcabcbb";
        Console.WriteLine(lengthOfLongestSubstring.LengthOfLongestSubstring(testCase));
        testCase = "bbbbb   ";
        Console.WriteLine(lengthOfLongestSubstring.LengthOfLongestSubstring(testCase));
        testCase = "bbbbb";
        Console.WriteLine(lengthOfLongestSubstring.LengthOfLongestSubstring(testCase));
        testCase = "pwwkew";
        Console.WriteLine(lengthOfLongestSubstring.LengthOfLongestSubstring(testCase));
        testCase = " ";
        Console.WriteLine(lengthOfLongestSubstring.LengthOfLongestSubstring(testCase));
        testCase = "au";
        Console.WriteLine(lengthOfLongestSubstring.LengthOfLongestSubstring(testCase));
    }

    public static void AddTwoNumbersTest()
    {
        int[] input = [2, 4, 3];
        int[] input2 = { 5, 6, 4 };
        ListNode l1 = new ListNode(input[0]);
        ListNode head1 = l1;
        for (int i = 1; i < input.Length; i++)
        {
            l1.next = new ListNode(input[i]);
            l1 = l1.next;
        }
        ListNode l2 = new ListNode(input2[0]);
        ListNode head2 = l2;
        for (int i = 1; i < input2.Length; i++)
        {
            l2.next = new ListNode(input2[i]);
            l2 = l2.next;
        }
        ListNode result = addTwoNumbers.AddTwoNumbers(head1, head2);
        while (result != null)
        {
            Console.WriteLine(result.val);
            result = result.next;
        }
    }

    static void FourthDay()
    {
        LengthOfLongestSubstringTest();
    }
    static void LengthOfLongestSubstringTest()
    {
        var fourthDay = new FourthDay();
        string testCase = "abcabcbb";
        Console.WriteLine(lengthOfLongestSubstring.LengthOfLongestSubstring(testCase));
        testCase = "bbbbb   ";
        Console.WriteLine(lengthOfLongestSubstring.LengthOfLongestSubstring(testCase));
        testCase = "bbbbb";
        Console.WriteLine(lengthOfLongestSubstring.LengthOfLongestSubstring(testCase));
        testCase = "pwwkew";
        Console.WriteLine(lengthOfLongestSubstring.LengthOfLongestSubstring(testCase));
        testCase = " ";
        Console.WriteLine(lengthOfLongestSubstring.LengthOfLongestSubstring(testCase));
        testCase = "au";
        Console.WriteLine(lengthOfLongestSubstring.LengthOfLongestSubstring(testCase));

    }

    public static void DotNetInterviewQuestions()
    {
        string name = "John Doe";
        // string extension method exist in ThirdDay.cs file
        Console.WriteLine(name.StringExtension());


    }

    public static async IAsyncEnumerable<int> GenerateNumbers()
    {
        for (int i = 0; i < 5; i++)
        {
            await Task.Delay(500);
            yield return i;
        }
    }

    public static void LinQExample()
    {
        List<int> numbers = new() { 1, 2, 3, 4, 5 };
        var evenArray = numbers.Where(x => x % 2 == 0);
        Console.WriteLine("Even numbers:" + string.Join(", ", evenArray));
    }

    static void SimpleGeneric()
    {
        Action<string> printer = Print<string>;

        printer("Hello, Generic!");
    }
    static void Print<T>(T t)
    {
        Console.WriteLine(t);
    }

    private static void ThirdDay()
    {
        var thirdDay = new ThirdDay();
        string testCase = "]";

        Console.WriteLine(thirdDay.IsValid(testCase));
        int[] cost = [10, 15, 20];
        Console.WriteLine(thirdDay.MinCostClimbingStairs(cost));

        cost = [1, 100, 1, 1, 1, 100, 1, 1, 100, 1];
        Console.WriteLine(thirdDay.MinCostClimbingStairs(cost));

    }

    class Stack<T>
    {
        public delegate void StackDeletage(T[] item);
    }

    public static void DelegateExample()
    {
        MessageDelegate del = MessagePrinter;
        del("Hello, Delegate!");

        Func<int, int, int> add = (x, y) => x + y;
        Console.WriteLine(add(5, 3));

        Action<string> messagePrinter = MessagePrinter;
        messagePrinter("Hello, Action!");

        Stack<float>.StackDeletage stackDelegate = DoWork;

    }

    static void DoWork(float[] itmes) { }

    static void MessagePrinter(string message)
    {
        Console.WriteLine(message);
    }

}