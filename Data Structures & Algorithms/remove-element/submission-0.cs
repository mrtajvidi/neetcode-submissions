public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int i = 0, n = nums.Length;
        while (i < n)
        {
            if (nums[i] == val)
            {
                nums[i] = nums[--n];
            }
            else
            {
                i++;
            }
        }
        return n;
    }
}