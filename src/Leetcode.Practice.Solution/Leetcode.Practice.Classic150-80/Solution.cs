namespace Leetcode.Practice.Classic150_80
{
    public class Solution
    {
        public static int RemoveDuplicates1(int[] nums)
        {
            int n = nums.Length;
            if (n <= 2)
            {
                return n;
            }
            int slow = 2, fast = 2;
            while (fast < n)
            {
                if (nums[slow - 2] != nums[fast])
                {
                    nums[slow] = nums[fast];
                    ++slow;
                }
                ++fast;
            }
            return slow;
        }

        public static int RemoveDuplicates2(int[] nums)
        {
            if (nums.Length <= 2)
                return nums.Length;

            Dictionary<int, int> numDict = new();
            for (int i = 0; i < nums.Length; i++)
            {
                if (numDict.ContainsKey(nums[i]))
                {
                    int time = numDict[nums[i]];
                    switch (time)
                    {
                        case 1:
                            numDict[nums[i]]++;
                            break;
                        case 2:
                            nums[i] = int.MaxValue;
                            break;
                        default:
                            throw new Exception("Invalid appearance time.");
                    }
                }
                else
                {
                    // Add new item into Dict.
                    numDict.Add(nums[i], 1);
                }
            }

            Array.Sort(nums);

            return nums.Where(v => v != int.MaxValue).Count();
        }
    }
}
