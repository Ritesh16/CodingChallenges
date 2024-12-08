using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDataType.BinaryTree.Traversal.BFS.Levelorder.Recursive
{
    public class CodeFile<T>
    {
        public List<T> Traverse(Node<T> root)
        {
            var list = new List<IList<T>>();
            Traverse(root, list, 0);
            var output = new List<T>();

            if (list.Count > 0)
            {
                foreach (var l in list)
                {
                    output.AddRange(l);
                }
            }

            return output;
        }

        private void Traverse(Node<T> root, IList<IList<T>> list, int level)
        {
            if (root == null)
            {
                return;
            }

            if (list.Count > level)
            {
                var nodes = list[level];
                nodes.Add(root.Value);
            }
            else
            {
                var nodes = new List<T>();
                nodes.Add(root.Value);
                list.Add(nodes);
            }

            level++;
            Traverse(root.Left, list, level);
            Traverse(root.Right, list, level);  
        }
    }
}
