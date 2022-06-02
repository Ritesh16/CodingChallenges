using Practice.BinarySearchTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Sorting._1305.AllElementsin2BST
{
    public class CodeFile_Fast
    {
        public IList<int> GetAllElements(TreeNode root1, TreeNode root2)
        {
            var stack1 = new Stack<TreeNode>();
            var stack2 = new Stack<TreeNode>();
            var output = new List<int>();

            while (root1 != null || root2 != null ||
                  stack1.Count > 0 || stack2.Count > 0)
            {
                while (root1 != null)
                {
                    stack1.Push(root1);
                    root1 = root1.left;
                }

                while (root2 != null)
                {
                    stack2.Push(root2);
                    root2 = root2.left;
                }

                if (stack2.Count == 0 || stack1.Count > 0 &&
                   stack1.Peek().val <= stack2.Peek().val)
                {
                    root1 = stack1.Pop();
                    output.Add(root1.val);
                    root1 = root1.right;
                }
                else
                {
                    root2 = stack2.Pop();
                    output.Add(root2.val);
                    root2 = root2.right;
                }

            }

            return output;
        }
    }
}
