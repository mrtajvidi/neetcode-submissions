public class Solution {
    public int Search(int[] nums, int target) {

        var n = 0;
        var m = nums.Length - 1;

        while (n <= m)
        {
            var mid = n + (m - n) / 2;

            if (nums[mid] == target)
            {
                return mid;
            }
            else if (nums[mid] < target )
            {
                n++;
            }
            else
            {
                m--;
            }            
        }
        return -1;
    }
}
