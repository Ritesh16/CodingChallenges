// See https://aka.ms/new-console-template for more information
using TreeDataType.BinaryTree;

Console.WriteLine("Binary Tree Traversal!");

var node = new Node<string>("A");

var leftTree = new Node<string>("B");
leftTree.Left = new Node<string>("D");
leftTree.Right = new Node<string>("E");

node.Left = leftTree;

var rightTree = new Node<string>("C");
rightTree.Left = new Node<string>("F");
rightTree.Right = new Node<string>("G");

node.Right = rightTree;

Console.WriteLine("****************************************");
Console.WriteLine("Preorder Recursive");
var preorder_Recursive = new TreeDataType.BinaryTree.Traversal.Preorder.Recursive.CodeFile<string>();
preorder_Recursive.Traverse(node);

Console.WriteLine("****************************************");
Console.WriteLine();

Console.WriteLine("Inorder Recursive");
var inorder_Recursive = new TreeDataType.BinaryTree.Traversal.Inorder.Recursive.CodeFile<string>();
inorder_Recursive.Traverse(node);

Console.WriteLine("****************************************");
Console.WriteLine();

Console.WriteLine("Postorder Recursive");
var postorder_Recursive = new TreeDataType.BinaryTree.Traversal.Postorder.Recursive.CodeFile<string>();
postorder_Recursive.Traverse(node);

Console.WriteLine("****************************************");
Console.WriteLine();
