using LeetCode.Shared;

namespace Leetcode;

public class DeleteDuplicates
{
    public class Solution {
        public ListNode DeleteDuplicatesSlow(ListNode head)
        {
            if (head is null) return head;
            var nodes = GetAllNodes(head);
            var distinctNodes = nodes.DistinctBy(x => x.val);
            var res = distinctNodes.First();
            var currNode = res;
            foreach (var listNode in distinctNodes.Skip(1))
            {
                currNode.next = listNode;
                currNode = currNode.next;
            }

            currNode.next = null;

            return res;
        }
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head is null) return head;
            var res = head;
            var curr = res;
            while (curr is not null)
            {
                if(curr.next is not null && curr.val == curr.next.val)
                    curr.next = curr.next.next;
                else
                    curr = curr.next;
            }

            return res;
        }
        public IEnumerable<ListNode> GetAllNodes(ListNode list)
        {
            var currNode = list;
            while (currNode is not null)
            {
                yield return currNode;
                currNode = currNode.next;
            }
        }
    }
}