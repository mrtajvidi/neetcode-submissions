public class Solution {
    public int MajorityElement(int[] nums) {
        
        // create a dic of num, occurance
        // iterate through the array and count the values 
        // if value > nums.Length / 2 return immediately


        // [5,5,1,1,1,5,5]
        // [4,4,0,0,0,4,4]

        int res = 0, count = 0;

        foreach (int num in nums)
        {
            if (count == 0)
            {
                res = num;
            }
            count += (num == res) ? 1 : -1;
        }

        return res;
    }
}