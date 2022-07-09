namespace Practice.BinaryTree._2236.RootEqualsSumofChildren
{
    public class CodeFile
    {
        public bool CheckTree(TreeNode root)
        {
            return root.val == root.left.val + root.right.val;
        }
    }
}
