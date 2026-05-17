public class Solution {
    List<List<int>> res;
    public List<List<int>> CombinationSum2(int[] candidates, int target) {
        Array.Sort(candidates);
        res = new List<List<int>>();
        Dfs(candidates, target, 0, new List<int>(), 0);
        return res;
    }

    void Dfs(int[] candids, int target, int total, List<int> curr, int i)
    {
        if (total == target)
        {
            res.Add(new List<int>(curr));
            return;
        }

        if (total > target || i == candids.Length)
        { 
            return;
        }

        curr.Add(candids[i]);
        Dfs(candids, target, total + candids[i], curr, i + 1);
        curr.RemoveAt(curr.Count - 1);
        
        while (i + 1 < candids.Length && candids[i+1] == candids[i])
        {
            i++;
        }

        Dfs(candids, target, total, curr, i + 1);        
    }
}
