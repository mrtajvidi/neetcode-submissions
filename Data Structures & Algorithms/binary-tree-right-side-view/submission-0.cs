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
    public List<int> RightSideView(TreeNode root) {
        
        // traverse the tree with level order traversal
        // add left first and then right to the queue 
        // add the last element of each level to the output list
        var res = new List<int>();

        if (root == null) return res;

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root); 
        
        while (queue.Count > 0)
        {
            var count = queue.Count;
            // count: 1, 2, 2

            for (int i = count; i > 0; i-- )
            {
                // i: 2, 1

                var node = queue.Dequeue();
                // node: 2, 3, 5, 4

                if (i == 1)
                {
                    res.Add(node.val);
                    // res: {1, 3,  4 }
                }
                if (node.left != null) {
                    queue.Enqueue(node.left);
                }

                 if (node.right != null) {

                    queue.Enqueue(node.right);
                 }
                // queue: { X1, x2, x3 , x5, x4 }
            }
        }

         return res;
    }
}
