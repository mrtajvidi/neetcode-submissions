/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public int GoodNodes(TreeNode root) {
        return Dfs(root, root.val);
    }

    private int Dfs(TreeNode root, int maxValue)
    {
        if (root == null) return 0;

        int res = root.val >= maxValue ? 1 : 0;
        maxValue = Math.Max(maxValue, root.val);

        res += Dfs(root.left, maxValue);
        res += Dfs(root.right, maxValue);

        return res;

    }
}
