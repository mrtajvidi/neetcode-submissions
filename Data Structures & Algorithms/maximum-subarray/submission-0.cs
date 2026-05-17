public class Solution {
    public int MaxSubArray(int[] nums) {
        var maxSum = nums[0];
        var curSum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            curSum = curSum < 0 ? 0 : curSum;
            curSum += nums[i];
            maxSum = Math.Max(maxSum, curSum);
        }
        return maxSum;
    }
}
