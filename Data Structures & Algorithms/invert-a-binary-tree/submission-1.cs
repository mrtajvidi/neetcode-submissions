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
    public TreeNode InvertTree2(TreeNode root) {
        if (root == null) return null;

        var node = new TreeNode(root.val);

        node.left = InvertTree(root.right);
        node.right = InvertTree(root.left);

        return node;
    }

    public TreeNode InvertTree(TreeNode root) {
        if (root == null) return null;

        var stack = new Stack<TreeNode>();
        stack.Push(root);

        while (stack.Count > 0)
        {
            var node = stack.Pop();
            var tmp = node.left;
            node.left = node.right;
            node.right = tmp;

            if (node.left != null) stack.Push(node.left);
            if (node.right != null) stack.Push(node.right);            
        }
        return root;
    }
}
