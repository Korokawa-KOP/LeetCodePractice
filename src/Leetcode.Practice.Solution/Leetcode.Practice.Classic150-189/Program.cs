using Leetcode.Practice.Classic150_189;

int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7 };

Solution.Rotate(nums, 3);

Console.WriteLine(string.Join(',', nums));

nums = new int[] { -1 };

Solution.Rotate(nums, 2);

Console.WriteLine(string.Join(',', nums));
