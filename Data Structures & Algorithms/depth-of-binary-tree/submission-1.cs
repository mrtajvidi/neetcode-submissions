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
    public int MaxDepth1(TreeNode root) {
        if (root == null) return 0;
        return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
    }


    public int MaxDepth(TreeNode root) {
        var stack = new Stack<Tuple<TreeNode, int>>();
        stack.Push(new Tuple<TreeNode, int>(root, 1));
        int res = 0;

        while (stack.Count > 0)
        {
            var cur = stack.Pop();

            var node = cur.Item1;
            int dept = cur.Item2;

            if (node != null)
            {
                res = Math.Max(res, dept);
                stack.Push(new Tuple<TreeNode, int>(node.left, dept + 1));
                stack.Push(new Tuple<TreeNode, int>(node.right, dept + 1));
            }
        }

        return res;
    }
}
