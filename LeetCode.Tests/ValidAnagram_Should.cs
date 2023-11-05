using Leetcode;

namespace LeetCode.Tests;

public class ValidAnagram_Should
{
    [Fact]
    public void Anagram_Should_Return_True()
    {
        var sut = new ValidAnagram.Solution();
        var s = "anagram";
        var t = "nagaram";
        var actual = sut.IsAnagram3(s, t);
        Assert.True(actual);
    }
    
    [Fact]
    public void Rat_Should_Return_False()
    {
        var sut = new ValidAnagram.Solution();
        var s = "rat";
        var t = "car";
        var actual = sut.IsAnagram3(s, t);
        Assert.False(actual);
    }
    
    [Fact]
    public void A_Should_Return_False()
    {
        var sut = new ValidAnagram.Solution();
        var s = "a";
        var t = "ab";
        var actual = sut.IsAnagram3(s, t);
        Assert.False(actual);
    }
}