namespace Leetcode.Practice.Classic150_274
{
    public class Solution
    {
        public static int HIndex(int[] citations)
        {
            int i = 0;
            while (i <= citations.Length)
            {
                if (citations.Count(c => c >= i) < i)
                    break;
                i++;
            }
            return i - 1;
        }
    }
}
