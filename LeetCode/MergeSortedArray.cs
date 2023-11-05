namespace Leetcode;

public class MergeSortedArray
{
    public class Solution {
        public void Merge(int[] nums1, int m, int[] nums2, int n){
            for(var i = m; i < m + n; i++)
            {
                nums1[i] = nums2[i - m];
            }
            Array.Sort(nums1);
        }
    } 
}
