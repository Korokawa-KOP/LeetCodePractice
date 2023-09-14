using Leetcode.Practice.Classic150_27;

int[] nums = new int[] { 3, 2, 2, 3 };
int val = 3;

int length = Solution.RemoveElement(nums, val);

Console.WriteLine(length);
Console.WriteLine(string.Join(',', nums));
