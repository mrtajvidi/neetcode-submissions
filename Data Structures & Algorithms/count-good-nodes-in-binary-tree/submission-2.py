# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

class Solution:
    def goodNodes(self, root: TreeNode) -> int:
        stack = [(root, root.val)]
        result = 0

        while stack:
            cur_node, max_so_far = stack.pop()

            if cur_node.val >= max_so_far:
                result += 1

            new_max_so_far = max(max_so_far, cur_node.val)
            if cur_node.left is not None:
                stack.append((cur_node.left, new_max_so_far))
            if cur_node.right is not None:
                stack.append((cur_node.right, new_max_so_far))

        return result

        