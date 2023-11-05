namespace Leetcode;

public class Sqrt_x_
{
    public class Solution
    {
        public int MySqrt(int x)
        {
            long xx = x;
            long currRes = 0;
            while (currRes * currRes <= xx)
            {
                currRes++;
            }

            return (int)--currRes;
        }
    }
}