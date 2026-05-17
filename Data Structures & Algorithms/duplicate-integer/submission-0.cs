public class Solution {
    public bool hasDuplicate(int[] nums) {
        var setOfNums = new HashSet<int>();
        foreach (var num in nums)
        {
            if (setOfNums.Contains(num)) return true;
            else {
                setOfNums.Add(num);
            }           
        }
        return false;
    }
}
