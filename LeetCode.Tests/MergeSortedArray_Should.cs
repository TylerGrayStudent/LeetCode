using Leetcode;

namespace LeetCode.Tests;

public class MergeSortedArray_Should
{
    [Fact]
    public void _1_2_3_0_0_0_Should_Equal_1_2_2_3_5_6()
    {
        var sut = new MergeSortedArray.Solution();
        var nums1 = new[] {1, 2, 3, 0, 0, 0};
        var nums2 = new[] {2, 5, 6};
        sut.Merge(nums1, 3, nums2, 3);
        var expected = new[] {1, 2, 2, 3, 5, 6};
        Assert.Equal(expected, nums1);
    }
}