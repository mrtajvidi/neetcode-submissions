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
    public int DiameterOfBinaryTree(TreeNode root) {
        var output = 0;
        DFS(root, ref output);
        return output;
    }

    private int DFS(TreeNode root, ref int output)
    {
        if (root == null) return 0;

        int left = DFS(root.left, ref output);
        int right = DFS(root.right, ref output);

        output = Math.Max(output, left + right);

        return 1 + Math.Max(left, right);
    }
}
