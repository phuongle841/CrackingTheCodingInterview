using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview.LeetCode150
{
    public class addTwoNumbers
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummy = new ListNode();
            ListNode current = dummy;
            int carrier = 0;

            while (l1 != null || l2 != null || carrier != 0)
            {
                int val1 = l1 != null ? l1.val : 0;
                int val2 = l2 != null ? l2.val : 0;

                int sum = val1 + val2 + carrier;
                carrier = sum / 10;
                current.next = new ListNode(sum % 10);
                current = current.next;
                if (l1 != null) l1 = l1.next;
                if (l2 != null) l2 = l2.next;
            }
            return dummy.next;
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
    }
}
