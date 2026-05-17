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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        var pVal = p.val;
        var qVal = q.val;
        var node = root;

        while (node != null)
        {
            var parentVal = node.val;

            if (pVal > parentVal && qVal > parentVal)
            {
                node = node.right;
            }
            else if (pVal < parentVal && qVal < parentVal)
            {
                node = node.left;
            }
            else
            {
                return node;
            }
        }

        return null;
    }
}
