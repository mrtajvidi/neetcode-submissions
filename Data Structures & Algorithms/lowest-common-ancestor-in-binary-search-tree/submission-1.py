# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

class Solution:
    def lowestCommonAncestor(self, root: TreeNode, p: TreeNode, q: TreeNode) -> TreeNode:
        node = root
        pVal, qVal = p.val, q.val

        while node:
            parentVal = node.val

            if pVal > parentVal and qVal > parentVal:
                node = node.right
            elif pVal < parentVal and qVal < parentVal:
                node = node.left
            else:
                return node
        return None