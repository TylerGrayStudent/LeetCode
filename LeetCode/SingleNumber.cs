﻿namespace Leetcode;

public class SingleNumber
{
    public class Solution {

        public int SingleNumber(int[] nums)
        {
            var res = 0;
            foreach (var num in nums)
            {
                res ^= num;
            }
            return res;
        }
        public int SingleNumber1(int[] nums)
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
            return dict.Where(x => x.Value== 1).Select(x => x.Key).First();
        }
    }
}