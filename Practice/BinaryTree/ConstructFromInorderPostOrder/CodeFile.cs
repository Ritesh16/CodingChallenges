using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Practice.BinaryTree.ConstructFromInorderPostOrder
{
    public class CodeFile
    {

        public TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            //var post = new Stack<int>(postorder);
            //var index = inorder.Select((val, index) => (val, index))
            //                   .ToDictionary(x => x.val, x => x.index);
            //return Build(0, inorder.Length - 1);

            //TreeNode Build(int left, int right)
            //{
            //    if (left > right) return null;

            //    var val = post.Pop();
            //    var i = index[val];

            //    return new TreeNode(val)
            //    {
            //        right = Build(i + 1, right),
            //        left = Build(left, i - 1)
            //    };
            //}

            var stack = new Stack<int>(postorder);
            var hashTable = inorder.Select((val, index) => (val, index))
                                   .ToDictionary(x => x.val, x => x.index);

            return Build(0, inorder.Length - 1);


            TreeNode Build(int left, int right)
            {
                if (left > right)
                    return null;

                var last = stack.Pop();
                var index = hashTable[last];

                var root = new TreeNode(last);

                root.right = Build(index + 1, right);
                root.left = Build(left, index - 1);
                return root;
            }

        }
    }
}
