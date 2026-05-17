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
    public TreeNode InvertTree(TreeNode root) {
        if (root == null) return null;

        var stack = new Stack<TreeNode>();
        stack.Push(root);
        while (stack.Count > 0)
        {
            var cur = stack.Pop();
            var temp = cur.left;
            cur.left = cur.right;
            cur.right = temp;
            if (cur.left != null) stack.Push(cur.left);
            if (cur.right != null) stack.Push(cur.right);
        }
        return root;
    }
}
