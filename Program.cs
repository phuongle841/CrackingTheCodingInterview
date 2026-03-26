// See https://aka.ms/new-console-template for more information



using CrackingTheCodingInterview.LeetCode150;
using Microsoft.VisualBasic.FileIO;
using static CrackingTheCodingInterview.LeetCode150.addTwoNumbers;
using static System.Net.Mime.MediaTypeNames;

public class Program
{
    delegate void MessageDelegate(string message);

    public static async Task Main(string[] args)
    {
        LongestPalidromeTest();
    }

    static void LongestPalidromeTest()
    {
        string testCase = "baba";
        Console.WriteLine("Longest Palindrome of \"{0}\" is: {1}",testCase,longestPalindrome.LongestPalindrome(testCase));
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