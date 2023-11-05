using Leetcode;
using LeetCode.Shared;

namespace LeetCode.Tests;

public class DeleteDuplicates_Should
{
    [Fact]
    public void _1_1_2_Should_Equal_1_2()
    {
        var sut = new DeleteDuplicates.Solution();
        var head = new ListNode(1, new ListNode(1, new ListNode(2)));
        var actual = sut.DeleteDuplicates(head);
        var expected = new ListNode(1, new ListNode(2));
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void _1_1_2_3_3_Should_Equal_1_2_3()
    {
        var sut = new DeleteDuplicates.Solution();
        var head = new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(3)))));
        var actual = sut.DeleteDuplicates(head);
        var expected = new ListNode(1, new ListNode(2, new ListNode(3)));
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void NullList_Should_Equal_Null()
    {
        var sut = new DeleteDuplicates.Solution();
        ListNode? head = null;
        var actual = sut.DeleteDuplicates(head);
        ListNode? expected = null;
        Assert.Equal(expected, actual);
    }
}