public class Solution {
    public int FindMin(int[] nums) {
    // [3,4,5,6,1,2]
    //  l   m     r

    //[6,1,2,3,4,5]
    // l   m     r

    //  m > l && m < r  --> look on the right 
    //  m < l && m < r  --> look on the left
    //  m > l && m < r  --> Normal case: look on the left 
        int l = 0, r = nums.Length - 1;       

        while (l < r)
        {
            var m = l + (r - l)/2;
            if (nums[m] < nums[r])
            {
                r = m;
            }
            else
            {
                l = m + 1;
            }
        }

        return nums[l];
    }
}
