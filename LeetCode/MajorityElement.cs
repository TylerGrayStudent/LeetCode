namespace Leetcode;

public class MajorityElement
{
    public class Solution {
        public int MajorityElement2(int[] nums)
        {
            var dict = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (dict.ContainsKey(num))
                {
                    dict[num]++;
                }
                else
                {
                    dict.Add(num, 1);
                }
            }

            var max = dict.Max(x => x.Value);
            return dict.First(x => x.Value == max).Key;
        }
        
        public int MajorityElement(int[] nums)
        {
            var majorCount = nums.Length / 2;
            return nums.FirstOrDefault(x => nums.Count(y => y == x) > majorCount);
        }
    }
}