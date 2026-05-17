public class Solution {
    public int LongestConsecutive(int[] nums) {
        var set = new HashSet<int>(nums);

        var longest = 0;

        foreach (var num in nums)
        {
            if (!set.Contains(num - 1))
            {
                var length = 1;
                while (set.Contains(num + length))
                {
                    length++;
                }
                longest = Math.Max(longest, length);
            }
        }
        return longest;
    }
}
