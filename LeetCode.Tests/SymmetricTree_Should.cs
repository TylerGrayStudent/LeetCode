using Leetcode;
using LeetCode.Shared;

namespace LeetCode.Tests;

public class SymmetricTree_Should
{
    [Fact]
    public void _1_2_2_3_4_4_3_Should_Return_True()
    {
        var sut = new SymmetricTree.Solution();
        var root = new TreeNode(1, new TreeNode(2, new TreeNode(3), new TreeNode(4)), new TreeNode(2, new TreeNode(4), new TreeNode(3)));
        var actual = sut.IsSymmetric(root);
        Assert.True(actual);
    }
    
    [Fact]
    public void _1_2_2_null_3_null_3_Should_Return_False()
    {
        var sut = new SymmetricTree.Solution();
        var root = new TreeNode(1, new TreeNode(2, null, new TreeNode(3)), new TreeNode(2, null, new TreeNode(3)));
        var actual = sut.IsSymmetric(root);
        Assert.False(actual);
    }
}