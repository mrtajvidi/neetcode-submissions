public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        var output = new List<List<int>>();
        var cur = new List<int>();
        Dfs(nums, 0, cur, output);
        return output;
    }

    private void Dfs(int[] nums, int i, List<int> cur, List<List<int>> output)
    {
        if (i >= nums.Length)
        {
            output.Add(new List<int>(cur));
            return;
        }

        cur.Add(nums[i]);
        Dfs(nums, i + 1, cur, output);

        cur.RemoveAt(cur.Count - 1);
        Dfs(nums, i + 1, cur, output);        
    }
}
