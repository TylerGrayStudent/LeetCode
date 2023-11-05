namespace Leetcode;

public class MissingNumbers
{
    public class Solution
    {
        public int MissingNumbers(int[] nums)
        {
            var count = nums.Length;
            var sum =  count * (count + 1) / 2;
            var actualSum = nums.Sum();
            return sum - actualSum;
        }
    }
}