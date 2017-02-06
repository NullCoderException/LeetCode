using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class AddTwoNumbers002
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        /// <summary>
        /// Accepted solution using node traversal and addition [ACCEPTED]
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode l1temp = l1;
            ListNode l2temp = l2;
            ListNode temp = new ListNode(0);
            ListNode placeholder = temp;
            int sum = 0;
            int carry = 0;
            while (l1temp != null || l2temp != null || carry > 0)
            {
                sum += carry;
                carry = 0;
                if (l1temp != null)
                {
                    sum += l1temp.val;
                    l1temp = l1temp.next;
                }

                if (l2temp != null)
                {
                    sum += l2temp.val;
                    l2temp = l2temp.next;
                }

                if (sum >= 10)
                {
                    carry = sum / 10;
                    sum = sum % 10;
                }
                temp.next = new ListNode(sum);
                temp = temp.next;
                sum = 0;
            }
            return placeholder.next;
        }
    }
}
