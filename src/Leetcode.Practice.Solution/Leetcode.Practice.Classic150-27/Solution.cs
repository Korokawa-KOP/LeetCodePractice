namespace Leetcode.Practice.Classic150_27
{
    public class Solution
    {
        public static int RemoveElement(int[] nums, int val)
        {
            int matchedCount = 0;
            // Relocate elements in array.
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                {
                    nums[i] = int.MaxValue;
                    matchedCount++;
                }
            }
            Array.Sort(nums);

            return nums.Length - matchedCount;
        }
    }
}
