public class Solution {
    private List<List<int>> res;

    public List<List<int>> SubsetsWithDup(int[] nums) {
        res = new List<List<int>>();
        Array.Sort(nums);
        Backtrack(nums, new List<int>(), 0);
        return res;
    }

    private void Backtrack(int[] nums, List<int> subset, int i)
    {
        if (i == nums.Length)
        {
            res.Add(new List<int>(subset));
            return;
        }

        // Add all the subsets that include nums[i]
        subset.Add(nums[i]);
        Backtrack(nums, subset, i + 1);
        subset.RemoveAt(subset.Count - 1);

        // Add all the subsets that do not include nums[i]
        while (i + 1 < nums.Length && nums[i] == nums[i + 1])
        {
            i++;
        }

        Backtrack(nums, subset, i + 1);
    }
}
