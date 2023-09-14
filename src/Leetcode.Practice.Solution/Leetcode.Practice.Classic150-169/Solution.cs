namespace Leetcode.Practice.Classic150_169
{
    public class Solution
    {
        public static int MajorityElement(int[] nums)
        {
            return nums.GroupBy(n => n)
                .Select(g => new { MajorElement = g.Key, MajorElementCount = g.Count() })
                .OrderByDescending(e => e.MajorElementCount)
                .First()
                .MajorElement;
        }
    }
}
