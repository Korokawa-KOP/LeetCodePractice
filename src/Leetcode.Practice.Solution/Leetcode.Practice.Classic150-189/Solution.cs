namespace Leetcode.Practice.Classic150_189
{
    public class Solution
    {
        public static void Rotate(int[] nums, int k)
        {
            if (k >= nums.Length)
            {
                while (k > 0)
                {
                    int last = nums[nums.Length - 1];
                    for (int i = nums.Length - 1; i >= 0; i--)
                    {
                        if (i == 0)
                        {
                            nums[i] = last;
                        }
                        else
                        {
                            nums[i] = nums[i - 1];
                        }
                    }
                    k--;
                }
            }
            else
            {
                int[] backup = new int[k];

                for (int i = 0; i < k; i++)
                {
                    backup[i] = nums[nums.Length - k + i];
                }

                for (int j = nums.Length - 1; j >= 0; j--)
                {
                    if (j < k)
                    {
                        nums[j] = backup[j];
                    }
                    else
                    {
                        nums[j] = nums[j - k];
                    }
                }
            }
        }

        private static int[] RotateRecur(int[] nums)
        {
            int last = nums[nums.Length - 1];
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    nums[i] = last;
                }
                else
                {
                    nums[i] = nums[i - 1];
                }
            }
            return nums;
        }
    }
}
