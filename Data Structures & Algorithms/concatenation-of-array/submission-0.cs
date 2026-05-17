public class Solution {
    public int[] GetConcatenation(int[] nums) {
        var n = nums.Length;

        var output = new int[2 * n];
        for(int i = 0; i < n; i++)
        {
            output[i] = nums[i];
            output[i + n] = nums[i];
        }
        return output;
    }
}