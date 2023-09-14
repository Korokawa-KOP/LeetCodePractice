namespace Leetcode.Practice.Classic150_88
{
    public class Solution
    {
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            // Merge 2nd array into 1st array.
            for (int i = 0; i < n; i++)
            {
                nums1[m + i] = nums2[i];
            }
            int temp;
            // Sort 1st array.
            for (int i = 0; i < m + n - 1; i++)
            {
                for (int j = i + 1; j < m + n; j++)
                {
                    if (nums1[i] > nums1[j])
                    {
                        temp = nums1[i];
                        nums1[i] = nums1[j];
                        nums1[j] = temp;
                    }
                }
            }
        }
    }
}
