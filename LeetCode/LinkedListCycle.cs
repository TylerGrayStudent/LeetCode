using LeetCode.Shared;

namespace Leetcode;

public class LinkedListCycle
{
    public class Solution {
        public bool HasCycle(ListNode head)
        {
            var posion = 100001;
            while (head is not null)
            {
                if (head.val == posion) return true;
                head.val = posion;
                head = head.next;
            }

            return false;
        }
    }
}