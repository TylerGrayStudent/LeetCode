using Leetcode;
using LeetCode.Shared;

namespace LeetCode.Tests;

public class LinkedListCycle_Should
{
    [Fact]
    public void HasCycle()
    {
        var head = new ListNode(3);
        var node1 = new ListNode(2);
        var node2 = new ListNode(0);
        var node3 = new ListNode(-4);
        head.next = node1;
        node1.next = node2;
        node2.next = node3;
        node3.next = node1;
        var solution = new LinkedListCycle.Solution();
        var actual = solution.HasCycle(head);
        Assert.True(actual);
    }
    
    [Fact]
    public void HasCycle2()
    {
        var head = new ListNode(1);
        var node1 = new ListNode(2);
        head.next = node1;
        node1.next = head;
        var solution = new LinkedListCycle.Solution();
        var actual = solution.HasCycle(head);
        Assert.True(actual);
    }
    
    [Fact]
    public void HasCycle3()
    {
        var head = new ListNode(1);
        var solution = new LinkedListCycle.Solution();
        var actual = solution.HasCycle(head);
        Assert.False(actual);
    }
}