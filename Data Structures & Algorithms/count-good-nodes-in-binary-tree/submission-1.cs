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

        // [current node, max seen so far]
        Stack<(TreeNode curNode, int maxSoFar)> stack = new Stack<(TreeNode, int)>();
        var result = 0;
        stack.Push((root, root.val));

        while (stack.Count > 0)
        {
            var cur = stack.Pop();
            var curNode = cur.curNode;
            var maxSoFar = cur.maxSoFar;
            if (curNode.val >= maxSoFar)
            {
                result++;
            }

            var newMaxSoFar = Math.Max(cur.maxSoFar, curNode.val);
            if (curNode.left != null)
            {
                stack.Push((curNode.left, newMaxSoFar));
            }

            if (curNode.right != null)
            {
                stack.Push((curNode.right, newMaxSoFar));
            }
        }

        return result;
    }
}
