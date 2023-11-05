using LeetCode.Shared;

namespace Leetcode;

public class AddTwoNumbers
{
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var result = new ListNode();
            var currNode = result;
            while (l1 is not null && l2 is not null)
            {
                var tempTotal = l1.val + l2.val;
                tempTotal += currNode.val;
                var carryOver = tempTotal / 10;
                tempTotal %= 10;
                currNode.val = tempTotal;
                if (l1.next is not null || l2.next is not null || carryOver > 0)
                {
                    currNode.next = new ListNode(carryOver);
                    currNode = currNode.next;
                    if (l1.next is not null && l2.next is null) l2.next = new ListNode();

                    if (l2.next is not null && l1.next is null) l1.next = new ListNode();

                    l1 = l1.next;
                    l2 = l2.next;
                }
                else
                {
                    l1 = l1.next;
                    l2 = l2.next;
                }
            }

            return result;
        }
    }
}