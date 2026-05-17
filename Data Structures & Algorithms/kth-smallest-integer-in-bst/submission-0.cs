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
    public int KthSmallest(TreeNode root, int k) {
        // using Heap:
            // traverse the BST in any order
            // insert the elements in a min heap 
            // if the heap.Count > k, dequeue from the heap 
            // end of traversal ---> return heap.Dequeue()

        // Use BST's properties
            // start DFS from left, 
            // travers In-order -> left - root - right 
            // keep track of count 
            // return if count == k

        var stack = new Stack<TreeNode>();
        var count = 0;
        while (stack.Count > 0 || root != null)
        {
            while (root != null)
            {
                stack.Push(root);
                root = root.left;
            }

            root = stack.Pop();
            count++;
            if (count == k) return root.val;
            root = root.right;
        }

        return -1;
        
    }
}
