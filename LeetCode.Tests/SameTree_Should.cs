using Leetcode;
using LeetCode.Shared;

namespace LeetCode.Tests;

public class SameTree_Should
{
    [Fact]
    public void _1_2_3_And_1_2_3_Should_Be_True()
    {
        var sut = new SameTree.Solution();
        var p = new TreeNode(1, new TreeNode(2), new TreeNode(3));
        var q = new TreeNode(1, new TreeNode(2), new TreeNode(3));
        var actual = sut.IsSameTree(p, q);
        Assert.True(actual);
    }
    
    [Fact]
    public void _1_2_And_1_null_2_Should_Be_False()
    {
        var sut = new SameTree.Solution();
        var p = new TreeNode(1, new TreeNode(2), null);
        var q = new TreeNode(1, null, new TreeNode(2));
        var actual = sut.IsSameTree(p, q);
        Assert.False(actual);
    }
    
    [Fact]
    public void _1_2_1_And_1_1_2_Should_Be_False()
    {
        var sut = new SameTree.Solution();
        var p = new TreeNode(1, new TreeNode(2), new TreeNode(1));
        var q = new TreeNode(1, new TreeNode(1), new TreeNode(2));
        var actual = sut.IsSameTree(p, q);
        Assert.False(actual);
    }
    
}