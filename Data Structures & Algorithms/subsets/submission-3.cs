public class Solution {
    private List<List<int>> output;
    public List<List<int>> Subsets(int[] nums) {
        // DFS
        output = new List<List<int>>();
        Dfs(nums, 0, new List<int>());
        return output;        
    }

    private void Dfs(int[] nums, int i, List<int> cur)
    {
        // base class
        if (i >= nums.Length)
        {
            output.Add(new List<int>(cur));
            return;
        }
        
        cur.Add(nums[i]);
        Dfs(nums, i + 1, cur);
        cur.RemoveAt(cur.Count - 1);

        Dfs(nums, i + 1, cur);
    }
}
