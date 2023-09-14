using System.Diagnostics;

namespace Leetcode.Practice.Classic150_121
{
    public class Solution
    {
        public static int MaxProfit(int[] prices)
        {
            Stopwatch sw = new();
            sw.Start();
            int maxProfit = BestSolution(prices);
            sw.Stop();

            Console.WriteLine($"Consume time: {sw.ElapsedMilliseconds} ms");

            return maxProfit;
        }

        private static int Pop(int[] prices)
        {
            int maxProfit = 0;
            int profit = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                {
                    for (int j = i; j < prices.Length; j++)
                    {
                        if (prices[j] > prices[i - 1])
                            profit = prices[j] - prices[i - 1];

                        if (profit > maxProfit)
                            maxProfit = profit;
                    }
                }
            }

            return maxProfit;
        }

        private static int FindMaxMin(int[] prices)
        {
            int[] maxIndexes, minIndexes;
            int[] ascPrices = prices.OrderBy(p => p).ToArray();

            for (int j = prices.Length - 1; j > 0; j--)
            {
                for (int i = 0; i < j; i++)
                {
                    maxIndexes = prices.Select((p, idx) => p == ascPrices[j] ? idx : -1).Where(idx => idx != -1).ToArray();
                    minIndexes = prices.Select((p, idx) => p == ascPrices[i] ? idx : -1).Where(idx => idx != -1).ToArray();

                    foreach (int minIndex in minIndexes)
                    {
                        if (maxIndexes.Any(maxIndex => maxIndex > minIndex))
                            return ascPrices[j] - ascPrices[i];
                    }
                }
            }

            return 0;
        }

        private static int FindMaxProfit(int[] prices)
        {
            if (prices.SequenceEqual(prices.OrderByDescending(p => p).ToArray()))
                return 0;

            Dictionary<(int Max, int Min), int> profits = new();

            int[] maxIndexes, minIndexes;
            int[] ascPrices = prices.OrderBy(p => p).ToArray();

            for (int j = prices.Length - 1; j > 0; j--)
            {
                for (int i = 0; i < j; i++)
                {
                    if (ascPrices[j] - ascPrices[i] > 0)
                        profits.TryAdd((ascPrices[j], ascPrices[i]), ascPrices[j] - ascPrices[i]);
                }
            }

            foreach (KeyValuePair<(int Max, int Min), int> pair in profits.OrderByDescending(p => p.Value))
            {
                maxIndexes = prices.Select((p, idx) => p == pair.Key.Max ? idx : -1).Where(idx => idx != -1).ToArray();
                minIndexes = prices.Select((p, idx) => p == pair.Key.Min ? idx : -1).Where(idx => idx != -1).ToArray();

                foreach (int minIndex in minIndexes)
                {
                    if (maxIndexes.Any(maxIndex => maxIndex > minIndex))
                        return pair.Value;
                }
            }

            return 0;
        }

        private static int DoubleIndexes(int[] prices)
        {
            int slow = 0, fast, minValue = 0, maxProfit = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                {
                    slow = i - 1;
                    minValue = prices[i - 1];
                    for (fast = slow + 1; fast < prices.Length; fast++)
                    {
                        if (prices[fast] - minValue > maxProfit)
                        {
                            maxProfit = prices[fast] - minValue;
                        }
                    }
                    break;
                }
            }

            if (maxProfit == 0)
                return 0;

            while (slow < prices.Length - 1)
            {
                if (prices[slow] < minValue)
                {
                    minValue = prices[slow];

                    for (fast = slow + 1; fast < prices.Length; fast++)
                    {
                        if (prices[fast] - minValue > maxProfit)
                        {
                            maxProfit = prices[fast] - minValue;
                        }
                    }
                }
                slow++;
            }

            return maxProfit;
        }

        private static int BestSolution(int[] prices)
        {
            int minprice = int.MaxValue;
            int maxprofit = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minprice)
                {
                    minprice = prices[i];
                }
                else if (prices[i] - minprice > maxprofit)
                {
                    maxprofit = prices[i] - minprice;
                }
            }
            return maxprofit;
        }
    }
}
