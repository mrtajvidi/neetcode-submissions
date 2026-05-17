public class Solution {
    public int Trap(int[] height) {

        if (height == null || height.Length == 0) return 0;

        var left = 0;
        var right = height.Length - 1;
        var leftMax = height[left];
        var rightMax = height[right];
        var total = 0;

        while (left < right)
        {
            if (leftMax < rightMax)
            {
                left++;
                leftMax = Math.Max(leftMax, height[left]);
                total += leftMax - height[left];
            }
            else
            {
                right--;            
                rightMax = Math.Max(rightMax, height[right]);
                total += rightMax - height[right];
            }
        }
        return total;
    }
}
