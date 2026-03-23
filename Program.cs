// See https://aka.ms/new-console-template for more information



using Microsoft.VisualBasic.FileIO;
using static System.Net.Mime.MediaTypeNames;

public class Program
{
    delegate void MessageDelegate(string message);

    public static async Task Main(string[] args)
    {

        FourthDay();
    }

    static void FourthDay()
    {
        LengthOfLongestSubstringTest();
    }
    static void LengthOfLongestSubstringTest()
    {
        var fourthDay = new FourthDay();
        string testCase = "abcabcbb";
        Console.WriteLine(fourthDay.LengthOfLongestSubstring(testCase));
        testCase = "bbbbb   ";
        Console.WriteLine(fourthDay.LengthOfLongestSubstring(testCase));
        testCase = "bbbbb";
        Console.WriteLine(fourthDay.LengthOfLongestSubstring(testCase));
        testCase = "pwwkew";
        Console.WriteLine(fourthDay.LengthOfLongestSubstring(testCase));
        testCase = " ";
        Console.WriteLine(fourthDay.LengthOfLongestSubstring(testCase));
        testCase = "au";
        Console.WriteLine(fourthDay.LengthOfLongestSubstring(testCase));

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