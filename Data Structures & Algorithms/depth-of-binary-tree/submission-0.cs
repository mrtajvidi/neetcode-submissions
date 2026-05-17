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
    public int MaxDepth(TreeNode root) {
        if (root == null) return 0;

        return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
    }


    public int MaxDepth2(TreeNode root) {

        // recursion 
            // current depth = 1 + max(depth(left) + depth(right))


        // In order traversal 

        // create a stack 
        // maxD = 0;
        // push root
        // while stack not empty
            // do DFS on t
            // stack.pop()
            // while left != null; add to the stack 
        return 0;
    }
}
