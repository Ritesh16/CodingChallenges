using TreeDataType.BinaryTree;

namespace TreeDataType.BinarySearchTree.Types.Interfaces
{
    public interface IBinarySearchTree
    {
        Node<int> Root { get; set; }
        Node<int> Insert(int value);
        Node<int> Insert(Node<int> root, int value);
    }
}
