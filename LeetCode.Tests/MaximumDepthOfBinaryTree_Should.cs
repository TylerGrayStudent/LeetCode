using Leetcode;
using LeetCode.Shared;

namespace LeetCode.Tests;

public class MaximumDepthOfBinaryTree_Should
{
    [Fact]
    public void _3_9_20_null_null_15_7_Should_Return_3()
    {
        var sut = new MaximumDepthOfBinaryTree.Solution();
        var root = new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)));
        var actual = sut.MaxDepth(root);
        Assert.Equal(3, actual);
    }
    
    [Fact]
    public void _1_null_2_Should_Return_2()
    {
        var sut = new MaximumDepthOfBinaryTree.Solution();
        var root = new TreeNode(1, null, new TreeNode(2));
        var actual = sut.MaxDepth(root);
        Assert.Equal(2, actual);
    }
}