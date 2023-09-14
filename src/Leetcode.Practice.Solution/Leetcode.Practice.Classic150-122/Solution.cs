namespace Leetcode.Practice.Classic150_122
{
    public class Solution
    {
        public static int MaxProfit(int[] prices)
        {
            int slow = 0, fast = 0, totoalProfit = 0;

            while (slow < prices.Length - 1)
            {
                if (prices[slow + 1] > prices[slow])
                {
                    fast = slow + 1;

                    while (fast < prices.Length - 1 && prices[fast + 1] > prices[fast])
                    {
                        fast++;
                    }

                    totoalProfit += prices[fast] - prices[slow];
                    slow = fast + 1;
                }
                else
                {
                    slow++;
                }
            }

            return totoalProfit;
        }
    }
}
