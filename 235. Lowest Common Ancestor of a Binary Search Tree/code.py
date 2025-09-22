# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, x):
#         self.val = x
#         self.left = None
#         self.right = None

class Solution:
    def lowestCommonAncestor(self, root: 'TreeNode', p: 'TreeNode', q: 'TreeNode') -> 'TreeNode':
        left_val = p.val if p.val <= q.val else q.val
        right_val = q.val if q.val >= p.val else p.val
        while root:
            if left_val <= root.val and root.val <= right_val:
                return root
            elif left_val < root.val:
                root = root.left
            else:
                root = root.right
        return root
        