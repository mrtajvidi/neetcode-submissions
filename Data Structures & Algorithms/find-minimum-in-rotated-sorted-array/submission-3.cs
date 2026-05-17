public class Solution {
    public int FindMin(int[] nums) {
        int l = 0, r = nums.Length - 1, min = nums[0];

        if (nums.Length == 1) return nums[0];
        

        while (l <= r)
        {
            if (nums[l] < nums[r]) 
                return Math.Min(min, nums[l]);
                
            var mid = l + (r - l)/2;
            min = Math.Min(min, nums[mid]);
            if (nums[mid] >= nums[l])
            {
                l = mid + 1;
            }
            else
            {
                r = mid - 1;
            }
        }
        return min;
    }
}
