using Leetcode.Practice.Classic150_45;

int[] nums = new int[] { 2, 3, 1, 1, 4 };

int jump = Solution.Jump(nums);

Console.WriteLine(jump);

nums = new int[] { 2, 3, 0, 1, 4 };

jump = Solution.Jump(nums);

Console.WriteLine(jump);

nums = new int[] { 0 };

jump = Solution.Jump(nums);

Console.WriteLine(jump);
