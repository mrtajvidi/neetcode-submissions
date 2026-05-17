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
    private int res = 0;
    public int DiameterOfBinaryTree(TreeNode root) {
        Dfs(root);
        return res;
    }

    private int Dfs(TreeNode root)
    {
        if (root == null) return 0;

        var left = Dfs(root.left);
        var right = Dfs(root.right);

        res = Math.Max(res, left + right);

        return 1 + Math.Max(left, right);
    }
}
