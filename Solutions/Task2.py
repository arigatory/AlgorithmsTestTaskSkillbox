 class TreeNode:
     def __init__(self, val=0, left=None, right=None):
         self.val = val
         self.left = left
         self.right = right

    # Сложность.
    # Пусть N будет количеством узлов в дереве. 
      
    # Временная сложность: O(N).
    # Это связано с тем, что в рекурсивной функции longest_path мы входим и выходим из каждого узла только один раз. 
    # Мы знаем это, потому что каждый узел идет от своего родителя, 
    # а в дереве у узлов есть только один родитель. 
      
    # Пространственная сложность: O(N). 
    # Пространственная сложность зависит от размера неявного стека вызовов во время обхода DFS, 
    # который связан с высотой дерева. 
    # В худшем случае дерево скошено, поэтому высота дерева равна O(N). 
    # Если дерево сбалансировано, сложность будет O(logN).


class Solution:
    def diameterOfBinaryTree(self, root: TreeNode) -> int:
        diameter = 0

        def longest_path(node):
            if not node:
                return 0
            nonlocal diameter

            left_path = longest_path(node.left)
            right_path = longest_path(node.right)

            diameter = max(diameter, left_path + right_path)

            return max(left_path, right_path) + 1

        longest_path(root)
        return diameter