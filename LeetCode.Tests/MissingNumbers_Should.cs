using Leetcode;

namespace LeetCode.Tests;

public class MissingNumbers_Should
{
    [Fact]
    public void _3_0_1_Should_Return_2()
    {
        var sut = new MissingNumbers.Solution();
        var nums = new[] {3, 0, 1};
        var actual = sut.MissingNumbers(nums);
        Assert.Equal(2, actual);
    }
    
    [Fact]
    public void _0_1_Should_Return_2()
    {
        var sut = new MissingNumbers.Solution();
        var nums = new[] {0, 1};
        var actual = sut.MissingNumbers(nums);
        Assert.Equal(2, actual);
    }
    
    [Fact]
    public void _9_6_4_2_3_5_7_0_1_Should_Return_8()
    {
        var sut = new MissingNumbers.Solution();
        var nums = new[] {9, 6, 4, 2, 3, 5, 7, 0, 1};
        var actual = sut.MissingNumbers(nums);
        Assert.Equal(8, actual);
    }
}