namespace Task2;

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

class Solution
{
    /*
    Сложность.
    Пусть N будет количеством узлов в дереве. 
    
    Временная сложность: O(N).
    Это связано с тем, что в рекурсивной функции longestPath мы входим и выходим из каждого узла только один раз. 
    Мы знаем это, потому что каждый узел идет от своего родителя, 
    а в дереве у узлов есть только один родитель. 
    
    Пространственная сложность: O(N). 
    Пространственная сложность зависит от размера нашего неявного стека вызовов во время обхода DFS, 
    который связан с высотой дерева. 
    В худшем случае дерево скошено, поэтому высота дерева равна O(N). 
    Если дерево сбалансировано, сложность будет O(logN).

    */


    private int diameter;
    public int DiameterOfBinaryTree(TreeNode root)
    {
        diameter = 0;
        longestPath(root);
        return diameter;
    }
    private int longestPath(TreeNode node)
    {
        if (node == null) return 0;
        // рекурсивно находим самый длинный путь в
        // и левый дочерний элемент, и правый дочерний элемент
        int leftPath = longestPath(node.left);
        int rightPath = longestPath(node.right);

        // обновляем диаметр, если leftPath плюс rightPath больше
        diameter = Math.Max(diameter, leftPath + rightPath);

        // возвращаем самый длинный между leftPath и rightPath;
        // добавляем 1 для пути, соединяющего узел и его родителя
        return Math.Max(leftPath, rightPath) + 1;
    }
}