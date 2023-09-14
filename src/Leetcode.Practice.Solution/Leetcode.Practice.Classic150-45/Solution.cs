namespace Leetcode.Practice.Classic150_45
{
    public class Solution
    {
        public static int Jump(int[] nums)
        {
            if (nums.Length <= 1) return 0;

            int count = 0;
            while (nums.Length > 0)
            {
                nums = JumpSub(nums);
                count++;
            }
            return count;
        }

        private static int[] JumpSub(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] + i >= nums.Length - 1)
                {
                    if (i == 0)
                    {
                        return new int[0];
                    }
                    else
                    {
                        return nums.Take(i + 1).ToArray();
                    }
                }
            }

            return new int[0];
        }
    }
}
