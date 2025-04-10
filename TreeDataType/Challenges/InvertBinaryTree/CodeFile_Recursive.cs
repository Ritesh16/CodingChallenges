namespace TreeDataType.Challenges.InvertBinaryTree
{
    public class CodeFile_Recursive
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null) return null;

            var temp = root.Left;
            root.Left = root.Right;
            root.Right = temp;

            InvertTree(root.Left);
            InvertTree(root.Right);

            return root;
        }
    }
}
