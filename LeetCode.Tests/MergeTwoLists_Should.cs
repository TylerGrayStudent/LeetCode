using Leetcode;
using LeetCode.Shared;

namespace LeetCode.Tests;

public class MergeTwoLists_Should
{
    [Fact]
    public void _1_2_4_Merge_1_3_4_Should_Equal_1_1_2_3_4_4()
    {
        var sut = new MergeTwoLists.Solution();
        var l1 = new ListNode(1, new ListNode(2, new ListNode(4)));
        var l2 = new ListNode(1, new ListNode(3, new ListNode(4)));
        var expected = new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(4))))));
        var actual = sut.MergeTwoLists(l1, l2);
        Assert.Equal(expected, actual);
    }
}