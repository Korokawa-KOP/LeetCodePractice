using Leetcode.Practice.Classic150_80;

int[] nums = new int[] { 1, 1, 1, 2, 2, 3 };

int length = Solution.RemoveDuplicates2(nums);

Console.WriteLine(length);
Console.WriteLine(string.Join(',', nums));

nums = new int[] { 0, 0, 1, 1, 1, 1, 2, 3, 3 };

length = Solution.RemoveDuplicates2(nums);

Console.WriteLine(length);
Console.WriteLine(string.Join(',', nums));
