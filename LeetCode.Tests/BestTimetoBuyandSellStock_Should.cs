using Leetcode;

namespace LeetCode.Tests;

public class BestTimetoBuyandSellStock_Should
{
    [Fact]
    public void _7_1_5_3_6_4_Should_Return_5()
    {
        var sut = new BestTimetoBuyandSellStock.Solution();
        var actual = sut.MaxProfit(new[] {7, 1, 5, 3, 6, 4});
        var expected = 5;
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void _7_6_4_3_1_Should_Return_0()
    {
        var sut = new BestTimetoBuyandSellStock.Solution();
        var actual = sut.MaxProfit(new[] {7, 6, 4, 3, 1});
        var expected = 0;
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void _1_2_Should_Return_1()
    {
        var sut = new BestTimetoBuyandSellStock.Solution();
        var actual = sut.MaxProfit(new[] {1, 2});
        var expected = 1;
        Assert.Equal(expected, actual);
    }
}