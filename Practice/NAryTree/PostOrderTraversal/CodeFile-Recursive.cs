using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.NAryTree.PostOrderTraversal
{
    public class CodeFile_Recursive
    {
        public IList<int> Postorder(Node root)
        {
            var output = new List<int>();
            Traverse(root, output);

            return output;
        }

        private void Traverse(Node root, List<int> output)
        {
            if (root != null)
            {
                foreach (var item in root.children)
                {
                    Traverse(item, output);
                }

                output.Add(root.val);
            }
        }
    }
}
