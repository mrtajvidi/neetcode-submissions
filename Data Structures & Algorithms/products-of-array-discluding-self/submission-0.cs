public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        // create two dictionaries
        // dict 1: stores the products of all the left elements
        // dict 2: stores the products of all the right elements
        // for each element, find the left and the right products from
        // the 2 dictionaries
 int n = nums.Length;
        int[] res = new int[n];
        int[] pref = new int[n];
        int[] suff = new int[n];

        pref[0] = 1;
        suff[n - 1] = 1;
        for (int i = 1; i < n; i++) {
            pref[i] = nums[i - 1] * pref[i - 1];
        }
        for (int i = n - 2; i >= 0; i--) {
            suff[i] = nums[i + 1] * suff[i + 1];
        }
        for (int i = 0; i < n; i++) {
            res[i] = pref[i] * suff[i];
        }
        return res;
    }
}
