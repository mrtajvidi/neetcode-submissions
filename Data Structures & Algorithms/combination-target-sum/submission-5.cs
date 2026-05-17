public class Solution {
     List<List<int>> res = new List<List<int>>();

    public List<List<int>> CombinationSum(int[] nums, int target) {
        Dfs(0, new List<int>(), 0, nums, target);
        return res;
    }

    private void Dfs(int i, List<int> cur, int total, int[] nums, int target)
    {
        if (total == target)
        {
            res.Add(cur.ToList());
            return;
        }

        if (total > target || i >= nums.Length) return;

        cur.Add(nums[i]);

        // Add the same value to the list 
        Dfs(i, cur, total + nums[i], nums, target);
        cur.RemoveAt(cur.Count - 1);

        // Go to next value
        Dfs(i + 1, cur, total, nums, target);
    }
}
