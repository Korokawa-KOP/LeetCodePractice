namespace Leetcode.Practice.Classic150_26
{
    public class Solution
    {
        public static int RemoveDuplicates(int[] nums)
        {
            /*
            if (nums.Length < 2)
                return nums.Length;
            
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == int.MaxValue)
                    continue;

                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        nums[j] = int.MaxValue;
                    }
                }
            }

            Array.Sort(nums);

            int count;
            for (count = 0; count < nums.Length; count++) 
            {
                if (nums[count] == int.MaxValue)
                    break;
            }

            Array.Resize(ref nums, count);

            return count;
            */
            int n = nums.Length;
            if (n == 0)
            {
                return 0;
            }
            int fast = 1, slow = 1;
            while (fast < n)
            {
                if (nums[fast] != nums[fast - 1])
                {
                    nums[slow] = nums[fast];
                    ++slow;
                }
                ++fast;
            }
            return slow;
        }
    }
}
