using Leetcode;

namespace LeetCode.Tests;

public class PascalsTriangle_Should
{
    [Fact]
    public void _5_Should_Return_1_5_10_10_5_1()
    {
        var sut = new PascalsTriangle.Solution();
        var actual = sut.Generate(5);
        var expected = new List<IList<int>>
        {
            new List<int> {1},
            new List<int> {1, 1},
            new List<int> {1, 2, 1},
            new List<int> {1, 3, 3, 1},
            new List<int> {1, 4, 6, 4, 1}
        };
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void _1_Should_Return_1()
    {
        var sut = new PascalsTriangle.Solution();
        var actual = sut.Generate(1);
        var expected = new List<IList<int>>
        {
            new List<int> {1}
        };
        Assert.Equal(expected, actual);
    }
}