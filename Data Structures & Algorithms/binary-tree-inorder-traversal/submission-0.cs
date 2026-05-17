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
    public List<int> InorderTraversal(TreeNode root) {
        var output = new List<int>();
        if (root == null) return output;

        var stack = new Stack<TreeNode>();
        TreeNode cur = root;

        while (cur != null || stack.Count > 0)
        {
            while (cur != null)
            {
                stack.Push(cur);
                cur = cur.left;
            }

            cur = stack.Pop();
            output.Add(cur.val);
            cur = cur.right;            
        }
        return output;
    }
}