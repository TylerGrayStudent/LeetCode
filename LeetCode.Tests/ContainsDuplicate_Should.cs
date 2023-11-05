using Leetcode;

namespace LeetCode.Tests;

public class ContainsDuplicate_Should
{
    [Fact]
    public void _1_2_3_1_Should_Equal_True()
    {
        var sut = new ContainsDuplicate.Solution();
        var actual = sut.ContainsDuplicate(new[] {1, 2, 3, 1});
        Assert.True(actual);
    }
}