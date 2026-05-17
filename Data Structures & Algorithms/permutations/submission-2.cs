public class Solution {
    List<List<int>> res;
    public List<List<int>> Permute(int[] nums) {
        res = new List<List<int>>();
        Dfs(nums, new List<int>(), new bool[nums.Length]);
        return res;        
    }

    private void Dfs(int[] nums, List<int> cur, bool[] pick)
    {
        if (cur.Count == nums.Length)
        {
            res.Add(new List<int>(cur));
            return;
        }

        for (int j = 0; j < nums.Length; j++)
        {
            if (!pick[j])
            {
                cur.Add(nums[j]);
                pick[j] = true;
                Dfs(nums, cur, pick);
                cur.RemoveAt(cur.Count - 1);
                pick[j] = false;
            }
        }
    }
}
