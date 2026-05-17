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
    public List<int> PreorderTraversal(TreeNode root) {
        var output = new List<int>();
        if (root == null)  return output;

        var stack = new Stack<TreeNode>();
        stack.Push(root);

        while(stack.Count > 0)
        {
            var cur = stack.Pop();
            output.Add(cur.val);

            if (cur.right != null)
            {
                stack.Push(cur.right);
            }

            if (cur.left != null)
            { 
                stack.Push(cur.left);
            }            
        }

        return output;
    }
}