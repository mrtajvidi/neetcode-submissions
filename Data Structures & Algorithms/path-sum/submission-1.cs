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
    public bool HasPathSum(TreeNode root, int targetSum) {
        bool Dfs(TreeNode node, int curSum) {
            if (node == null) return false;

            curSum += node.val;
            if (node.left == null && node.right == null) {
                return curSum == targetSum;
            }

            return Dfs(node.left, curSum) || Dfs(node.right, curSum);
        }

        return Dfs(root, 0);
    }
}