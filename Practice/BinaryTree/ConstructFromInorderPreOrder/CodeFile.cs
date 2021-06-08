using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.BinaryTree.ConstructFromInorderPreOrder
{
    public class CodeFile
    {
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            var queue = new Queue<int>(preorder);
            var hashTable = inorder.Select((val, index) => (val, index))
                                   .ToDictionary(x => x.val, x => x.index);

            return Build(0, inorder.Length - 1);


            TreeNode Build(int left, int right)
            {
                if (left > right)
                    return null;

                var last = queue.Dequeue();
                var index = hashTable[last];

                var root = new TreeNode(last);


                root.left = Build(left, index - 1);
                root.right = Build(index + 1, right);

                return root;
            }
        }
    }
}
