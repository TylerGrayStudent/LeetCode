using Leetcode;

namespace LeetCode.Tests;

public class MajorityElement_Should
{
    [Fact]
    public void _3_2_3_Should_Equal_3()
    {
        var sut = new MajorityElement.Solution();
        var actual = sut.MajorityElement(new[] {3, 2, 3});
        Assert.Equal(3, actual);
    }
}