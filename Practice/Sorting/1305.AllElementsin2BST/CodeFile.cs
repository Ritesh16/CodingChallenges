using Practice.BinarySearchTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Sorting._1305.AllElementsin2BST
{
    public class CodeFile
    {
        public IList<int> GetAllElements(TreeNode root1, TreeNode root2)
        {
            List<int> list1;
            List<int> list2;

            if (root1 == null)
            {
                list1 = new List<int>();
            }

            if (root2 == null)
            {
                list2 = new List<int>();
            }

            list1 = InOrder(root1);
            list2 = InOrder(root2);

            var list = new List<int>();
            var i = 0;
            var j = 0;

            while (i < list1.Count && j < list2.Count)
            {
                if (list1[i] > list2[j])
                {
                    list.Add(list2[j]);
                    j++;
                }
                else
                {
                    list.Add(list1[i]);
                    i++;
                }
            }

            while (i < list1.Count)
            {
                list.Add(list1[i]);
                i++;
            }

            while (j < list2.Count)
            {
                list.Add(list2[j]);
                j++;
            }

            return list;
        }

        public List<int> InOrder(TreeNode root)
        {
            var node = root;
            var stack = new Stack<TreeNode>();
            var list = new List<int>();

            while (node != null || stack.Count != 0)
            {
                while (node != null)
                {
                    stack.Push(node);
                    node = node.left;
                }

                node = stack.Pop();
                list.Add(node.val);

                node = node.right;
            }

            return list;
        }
    }
}
