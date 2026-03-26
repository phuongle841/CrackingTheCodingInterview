using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview.LeetCode150
{
    // Hard problem: not finished
    public class findMedianSortedArrays
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            double median = 0;
            int totalLength = nums1.Length + nums2.Length;
            int pointer1 = 0;
            int pointer2 = 0;

            while (pointer1+pointer2<totalLength)
            {
                pointer1++;
                pointer2++;
            }

            Console.WriteLine("{0}-{1}", nums1[pointer1], nums2[pointer2]);

            return double.MaxValue;
        }
    }
}
