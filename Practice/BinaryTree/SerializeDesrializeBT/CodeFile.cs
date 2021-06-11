using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.BinaryTree.SerializeDesrializeBT
{
    class CodeFile
    {
        public string serialize(TreeNode root)
        {
            var output = string.Empty;
            var builder = new StringBuilder();

            output = RecursivePreorder(root, builder);

            return output;
        }

        private string RecursivePreorder(TreeNode node, StringBuilder builder)
        {
            if (node != null)
            {
                builder.Append(node.val);
                builder.Append(",");
                RecursivePreorder(node.left, builder);
                RecursivePreorder(node.right, builder);

            }
            else
            {
                builder.Append("none");
                builder.Append(",");
            }

            return builder.ToString();
        }

        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data)
        {
            var array = data.Split(',');
            int ind = 0;

            var node = RecursivePreorder(array, ref ind);


            return node;
        }

        private TreeNode RecursivePreorder(string[] array, ref int count)
        {
            if (count >= array.Length || array[count] == "none")
            {
                return null;
            }

            TreeNode root = new TreeNode(Convert.ToInt32(array[count]));
            count++;
            root.left = RecursivePreorder(array, ref count);
            count++;

            root.right = RecursivePreorder(array, ref count);
            return root;
        }
    }
}
}
