namespace Practice.BinaryTree.MaxDepth
{
    public class CodeFile_Fast
    {
        int depth = 0;
        public int MaxDepth(TreeNode root)
        {
            FindDepth(root, 1);
            return depth;
        }

        private void FindDepth(TreeNode root, int currentDepth)
        {
            if (root == null) return;

            if (currentDepth > depth)
                depth = currentDepth;

            FindDepth(root.left, currentDepth + 1);
            FindDepth(root.right, currentDepth + 1);
        }
    }
}
