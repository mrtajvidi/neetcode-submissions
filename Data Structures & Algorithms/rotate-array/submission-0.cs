public class Solution {
    public void Rotate(int[] nums, int k) {
        var n = nums.Length;
        k %= n;

        Reverse(nums, 0, n - 1);
        Reverse(nums, 0, k - 1);
        Reverse(nums, k, n - 1);        
    }

    private void Reverse(int[] nums, int left, int right)
    {
        // 1, 2, 3, 4 
        // 4, 3, 2, 1

        // 1, 2, 3, 56, 45
        // 45, 56, 3, 2, 1

        while (left < right)
        {
            var temp = nums[left];
            nums[left] = nums[right];
            nums[right] = temp;
            left++;
            right--;
        }
    }
}