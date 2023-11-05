using Leetcode;

namespace LeetCode.Tests;

public class ClimbStairs_Should
{
    [Fact]
    public void _1_Should_Equal_1()
    {
        var sut = new ClimbingSquares.Solution();
        var actual = sut.ClimbStairs(1);
        Assert.Equal(1, actual);
    }
    
    [Fact]
    public void _2_Should_Equal_2()
    {
        var sut = new ClimbingSquares.Solution();
        var actual = sut.ClimbStairs(2);
        Assert.Equal(2, actual);
    }
    
    [Fact]
    public void _3_Should_Equal_3()
    {
        var sut = new ClimbingSquares.Solution();
        var actual = sut.ClimbStairs(3);
        Assert.Equal(3, actual);
    }
    
    [Fact]
    public void _4_Should_Equal_5()
    {
        var sut = new ClimbingSquares.Solution();
        var actual = sut.ClimbStairs(4);
        Assert.Equal(5, actual);
    }
    
    [Fact]
    public void _5_Should_Equal_8()
    {
        var sut = new ClimbingSquares.Solution();
        var actual = sut.ClimbStairs(5);
        Assert.Equal(8, actual);
    }
    
    [Fact]
    public void _6_Should_Equal_13()
    {
        var sut = new ClimbingSquares.Solution();
        var actual = sut.ClimbStairs(6);
        Assert.Equal(13, actual);
    }
    
    
    
}