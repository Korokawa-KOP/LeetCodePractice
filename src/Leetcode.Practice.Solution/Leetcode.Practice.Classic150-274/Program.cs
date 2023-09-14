using Leetcode.Practice.Classic150_274;

int[] nums = new int[] { 3, 0, 6, 1, 5 };

int jump = Solution.HIndex(nums);

Console.WriteLine(jump);

nums = new int[] { 1, 3, 1 };

jump = Solution.HIndex(nums);

Console.WriteLine(jump);

nums = new int[] { 0 };

jump = Solution.HIndex(nums);

Console.WriteLine(jump);

nums = new int[] { 11, 12 };

jump = Solution.HIndex(nums);

Console.WriteLine(jump);

nums = new int[] { 4, 4, 0, 0 };

jump = Solution.HIndex(nums);

Console.WriteLine(jump);
