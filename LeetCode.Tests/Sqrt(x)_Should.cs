using Leetcode;

namespace LeetCode.Tests;

public class Sqrt_x_Should
{
    [Fact]
    public void _4_Should_Equal_2()
    {
        var sut = new Sqrt_x_.Solution();
        var actual = sut.MySqrt(4);
        Assert.Equal(2, actual);
    }
    
    [Fact]
    public void _8_Should_Equal_2()
    {
        var sut = new Sqrt_x_.Solution();
        var actual = sut.MySqrt(8);
        Assert.Equal(2, actual);
    }
}