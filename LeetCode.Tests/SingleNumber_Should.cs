using Leetcode;

namespace LeetCode.Tests;

public class SingleNumber_Should
{
    [Fact]
    public void _2_2_1_Should_Return_1()
    {
        var sut = new SingleNumber.Solution();
        var actual = sut.SingleNumber(new[] {2, 2, 1});
        var expected = 1;
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void _4_1_2_1_2_Should_Return_4()
    {
        var sut = new SingleNumber.Solution();
        var actual = sut.SingleNumber(new[] {4, 1, 2, 1, 2});
        var expected = 4;
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void _1_Should_Return_1()
    {
        var sut = new SingleNumber.Solution();
        var actual = sut.SingleNumber(new[] {1});
        var expected = 1;
        Assert.Equal(expected, actual);
    }
}