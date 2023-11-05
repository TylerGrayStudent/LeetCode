using System.Text;

namespace LeetCode.Shared;

public class ListNode
{
    public ListNode next;
    public int val;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
    
    public ListNode(double total) {
        var totalString = total.ToString().Reverse();
        var currNode = this;
        for (var i = 0; i < totalString.Count(); i++)
        {
            currNode.val = int.Parse(totalString.ElementAt(i).ToString());
            if (i == totalString.Count() - 1) continue;
            currNode.next = new ListNode();
            currNode = currNode.next;
        }
    }

    public IEnumerable<ListNode> GetAllNodes(ListNode list)
    {
        var currNode = list;
        while (currNode.next is not null)
        {
            yield return currNode;
            currNode = currNode.next;
        }
    }
    

    public override bool Equals(object? obj)
    {
        if (obj is not ListNode node) return false;
        var currNode = this;
        var currNode2 = node;
        while (currNode is not null && currNode2 is not null)
        {
            if (currNode.val != currNode2.val) return false;
            currNode = currNode.next;
            currNode2 = currNode2.next;
        }

        return currNode is null && currNode2 is null;
    }
}