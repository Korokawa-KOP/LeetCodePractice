using Leetcode.Practice.Classic150_88;

int[] nums1 = new int[] { 4, 5, 6, 0, 0, 0 };
int m = 3;
int[] nums2 = new int[] { 1, 2, 3 };
int n = 3;

Solution.Merge(nums1, m, nums2, n);

Console.WriteLine(string.Join(',', nums1));
