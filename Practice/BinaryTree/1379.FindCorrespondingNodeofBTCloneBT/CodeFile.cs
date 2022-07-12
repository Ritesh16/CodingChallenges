namespace Practice.BinaryTree._1379.FindCorrespondingNodeofBTCloneBT
{
    public class CodeFile
    {
        TreeNode answer;
        TreeNode target;
        public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target)
        {
            this.target = target;
            PreOrder(original, cloned);

            return answer;
        }

        public void PreOrder(TreeNode original, TreeNode cloned)
        {
            if (original != null)
            {
                if (original == target)
                {
                    answer = cloned;
                    return;
                }

                PreOrder(original.left, cloned.left);

                PreOrder(original.right, cloned.right);
            }
        }
    }
}
