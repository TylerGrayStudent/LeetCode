using Leetcode;
using LeetCode.Shared;

namespace LeetCode.Tests;

public class AddTwoNumbersShould
{
    [Fact]
    public void _342_Plus_465_Should_Equal_807()
    {
        var sut = new AddTwoNumbers.Solution();
        var l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
        var l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
        var expected = new ListNode(7, new ListNode(0, new ListNode(8)));
        var actual = sut.AddTwoNumbers(l1, l2);
        Assert.Equal(expected, actual);
    }

    // 1,9,9,9,9,9,9,9,9,9 + 9
    [Fact]
    public void
        _19999999999_Plus_9_Should_Equal_20000000008()
    {
        var sut = new AddTwoNumbers.Solution();
        var l1 = new ListNode(19999999999D);
        var l2 = new ListNode(9D);
        var expected = new ListNode(20000000008L);
        var actual = sut.AddTwoNumbers(l1, l2);
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void _991_Plus_79_Should_Equal_1070()
    {
        var sut = new AddTwoNumbers.Solution();
        var l1 = new ListNode(991D);
        var l2 = new ListNode(79D);
        var expected = new ListNode(1070D);
        var actual = sut.AddTwoNumbers(l1, l2);
        Assert.Equal(expected, actual);
    }
}