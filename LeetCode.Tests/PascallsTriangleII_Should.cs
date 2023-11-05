using Leetcode;

namespace LeetCode.Tests;

public class PascallsTriangleII_Should
{
    [Fact]
    public void _3_Should_Return_1_3_3_1()
    {
        var sut = new PascalsTriangleII.Solution();
        var actual = sut.GetRow(3);
        var expected = new List<int> {1, 3, 3, 1};
        Assert.Equal(expected, actual);
    }
    
    
    [Fact]
    public void _1_Should_Return_1()
    {
        var sut = new PascalsTriangleII.Solution();
        var actual = sut.GetRow(1);
        var expected = new List<int> {1, 1};
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void _0_Should_Return_1()
    {
        var sut = new PascalsTriangleII.Solution();
        var actual = sut.GetRow(0);
        var expected = new List<int> {1};
        Assert.Equal(expected, actual);
    }
}