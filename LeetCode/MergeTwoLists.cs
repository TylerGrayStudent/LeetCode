using LeetCode.Shared;

namespace Leetcode;

public class MergeTwoLists
{
    public class Solution {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if(list1 is null && list2 is null) return list1;
            if(list1 is null && list2 is not null) return list2;
            if(list1 is not null && list2 is null) return list1;
            var allNodes = GetAllNodes(list1).Concat(GetAllNodes(list2));
            var sortedNodes = allNodes.OrderBy(x => x.val);
            var result = new ListNode(sortedNodes.First().val);
            var currNode = result;
            foreach (var node in sortedNodes.Skip(1))
            {
                currNode.next = new ListNode(node.val);
                currNode = currNode.next;
            }

            return result;
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