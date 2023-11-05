using Leetcode;
using LeetCode.Shared;

namespace LeetCode.Tests;

public class BinaryTreeInorderTraversal_Should
{
    [Fact]
    public void _1_2_3_Should_Return_1_2_3()
    {
        var sut = new BinaryTreeInorderTraversal.Solution();
        var root = new TreeNode(1, null, new TreeNode(2, new TreeNode(3), null));
        var actual = sut.InorderTraversal(root);
        Assert.Equal(new[] {1, 3, 2}, actual);
    }
    
    
    [Fact]
    public void _1_Should_Return_1()
    {
        var sut = new BinaryTreeInorderTraversal.Solution();
        var root = new TreeNode(1);
        var actual = sut.InorderTraversal(root);
        Assert.Equal(new[] {1}, actual);
    }
}