namespace Leetcode;

public class BestTimetoBuyandSellStock
{
    public class Solution {
        public int MaxProfit(int[] prices) {
            var maxProfit = 0;
            var minPrice = int.MaxValue;
            foreach (int price in prices)
            {
                minPrice = Math.Min(minPrice, price);
                maxProfit = Math.Max(maxProfit, price - minPrice);
            }

            return maxProfit;
        }
    }
}