namespace Leetcode.Practice.Classic150_55
{
    public class Solution
    {
        public static bool CanJump(int[] nums)
        {
            return CanJumpReversalRecur(nums);
        }

        private static bool CanJumpReversal(int[] nums)
        {
            int length = nums.Length;
            if (length <= 1)
                return true;

            for (int i = 1; i < length; i++)
            {
                if (nums[length - i - 1] >= i)
                {
                    // Check if current position is reachable.

                    return true;
                }
            }
            return false;
        }

        private static bool CanJumpReversalRecur(int[] nums)
        {
            int length = nums.Length;
            if (length <= 1)
                return true;

            for (int i = 1; i < length; i++)
            {
                if (nums[length - i - 1] >= i)
                {
                    // Check if current position is reachable.
                    if (CanJumpReversalRecur(nums.Take(length - i).ToArray()))
                        return true;
                }
            }
            return false;
        }

        private static bool CanJumpFromFirst(int[] nums)
        {
            if ((nums?.Length ?? 0) == 0)
                return false;

            return CanJumpRecur(nums, 0);
        }

        private static bool CanJumpRecur(int[] nums, int curPos)
        {
            if (curPos == nums.Length - 1)
            {
                return true;
            }
            if (curPos > nums.Length - 1)
            {
                return false;
            }
            for (int i = nums[curPos]; i >= 1; i--)
            {
                if (CanJumpRecur(nums, curPos + i))
                {
                    return true;
                }
            }
            return false;
        }

        private static bool CanJumpFromRandomStart(int[] nums)
        {
            if (nums.Length == 1)
                return true;

            int fast;
            bool canJump = false;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                fast = i;

                while (fast < nums.Length)
                {
                    if (fast == nums.Length - 1)
                    {
                        canJump = true;
                        break;
                    }

                    if (nums[fast] == 0)
                        break;

                    fast += nums[fast];
                }

                if (canJump)
                    break;
            }

            return canJump;
        }
    }
}
