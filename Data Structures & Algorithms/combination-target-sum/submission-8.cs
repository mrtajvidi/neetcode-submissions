public class Solution {
    private List<List<int>> res;

    public List<List<int>> CombinationSum(int[] nums, int target) {
        res = new List<List<int>>();
        Array.Sort(nums);
        Dfs(0, new List<int>(), 0, nums, target);
        return res;
    }

    private void Dfs(int i, List<int> cur, int total, int[] nums, int target) 
    {
        if (total == target)
        {
            res.Add(new List<int>(cur));
            return;
        }

        for (int j = i; j < nums.Length; j++)
        {
            if (total + nums[j] > target)
            {
                return;
            }

            cur.Add(nums[j]);
            Dfs(j, cur, total + nums[j], nums, target);
            cur.RemoveAt(cur.Count - 1);
        }
    }
}
