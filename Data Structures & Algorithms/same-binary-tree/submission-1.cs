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
    public bool IsSameTree2(TreeNode p, TreeNode q) {
        if (p == null && q == null) return true;

        if (p != null && q != null && p.val == q.val)
        {
            return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }
        else
        {
            return false;
        }        
    }

    public bool IsSameTree(TreeNode p, TreeNode q) {
        var q1 = new Queue<TreeNode>();
        var p1 = new Queue<TreeNode>();
        p1.Enqueue(p);
        q1.Enqueue(q);

        while (q1.Count > 0 && q1.Count > 0)
        {
            var curQ = q1.Dequeue();
            var curP = p1.Dequeue();
            if (curQ == null && curP == null) continue;

            if (curQ?.val != curP?.val) return false;

            p1.Enqueue(curP.left);
            p1.Enqueue(curP.right);
            q1.Enqueue(curQ.left);
            q1.Enqueue(curQ.right);
        }

        return (q1.Count == 0 && q1.Count == 0);
    }
}
