// See https://aka.ms/new-console-template for more information
using TreeDataType.BinaryTree;

Console.WriteLine("Binary Tree Traversal!");

var choice = "a";

while (choice == "a")
{
    Console.WriteLine();
    Console.WriteLine("*****************************************");
    Console.WriteLine("Binary Tree. Please choose the following.");
    Console.WriteLine("1. Preorder traversal using Recursion");
    Console.WriteLine("2. Preorder traversal using Iteration");
    Console.WriteLine("3. Inorder traversal using Recursion");
    Console.WriteLine("4. Inorder traversal using Iteration");
    Console.WriteLine("5. Postorder traversal using Recursion");
    Console.WriteLine("6. Postorder traversal using Iteration");
    Console.WriteLine("7. Levelorder traversal using Iteration");
    Console.WriteLine("8. Levelorder traversal using Recursion");
    Console.WriteLine("9. Count nodes using Recursion");
    Console.WriteLine("10.Count nodes using Iteration");
    Console.WriteLine("11. Height of Tree using Recursion");
    Console.WriteLine("12. Calculate leaf nodes of Tree using Recursion");
    Console.WriteLine("13. Calculate nodes with 2 children of Tree using Recursion");
    Console.WriteLine("14. Calculate nodes with 1 children of Tree using Recursion");
    Console.WriteLine("15. Insert in Binary Search Tree using Iteration.");
    Console.WriteLine("16. Insert in Binary Search Tree using Recursion.");

    Console.WriteLine("Press any key to continue or hit 'x' to quit.");

    choice = Console.ReadLine();

    var node = new Node<string>("A");

    var leftTree = new Node<string>("B");
    leftTree.Left = new Node<string>("C");
    leftTree.Right = new Node<string>("D");
    leftTree.Right.Right = new Node<string>("D1");

    node.Left = leftTree;

    var rightTree = new Node<string>("E");
    rightTree.Left = new Node<string>("F");
    rightTree.Right = new Node<string>("G");
    //rightTree.Right.Left = new Node<string>("H");
    //rightTree.Right.Left.Left = new Node<string>("I");

    node.Right = rightTree;

    switch (choice)
    {
        case "1":
            Console.WriteLine("****************************************");
            Console.WriteLine("Preorder Recursive");
            var preorder_Recursive = new TreeDataType.BinaryTree.Traversal.DFS.Preorder.Recursive.CodeFile<string>();
            preorder_Recursive.Traverse(node);

            Console.WriteLine("****************************************");
            Console.WriteLine();
            break;

        case "2":
            Console.WriteLine("****************************************");
            Console.WriteLine("Preorder Iterative");
            var preorder_Iterative = new TreeDataType.BinaryTree.Traversal.DFS.Preorder.Iterative.CodeFile<string>();
            var prepOrderList = preorder_Iterative.Traverse(node);
            foreach (var val in prepOrderList)
            {
                Console.WriteLine(val);
            }

            Console.WriteLine("****************************************");
            Console.WriteLine();
            break;

        case "3":
            Console.WriteLine("Inorder Recursive");
            var inorder_Recursive = new TreeDataType.BinaryTree.Traversal.DFS.Inorder.Recursive.CodeFile<string>();
            inorder_Recursive.Traverse(node);

            Console.WriteLine("****************************************");
            Console.WriteLine();
            break;

        case "4":
            Console.WriteLine("Inorder Iterative");
            var inorder_Iterative = new TreeDataType.BinaryTree.Traversal.DFS.Inorder.Iterative.CodeFile<string>();
            var inorderList = inorder_Iterative.Traverse(node);
            foreach (var val in inorderList)
            {
                Console.WriteLine(val);
            }

            Console.WriteLine("****************************************");
            Console.WriteLine();
            break;

        case "5":
            Console.WriteLine("Postorder Recursive");
            var postorder_Recursive = new TreeDataType.BinaryTree.Traversal.DFS.Postorder.Recursive.CodeFile<string>();
            postorder_Recursive.Traverse(node);
            Console.WriteLine("****************************************");
            Console.WriteLine();
            break;

        case "6":
            Console.WriteLine("Postorder Iterative");
            var postorder_Iterative = new TreeDataType.BinaryTree.Traversal.DFS.Postorder.Iterative.CodeFile<string>();
            var postorderList = postorder_Iterative.Traverse(node);

            foreach (var val in postorderList)
            {
                Console.WriteLine(val);
            }

            Console.WriteLine("****************************************");
            Console.WriteLine();
            break;

        case "7":
            Console.WriteLine("Levelorder Iterative");
            var levelorder_Iterative = new TreeDataType.BinaryTree.Traversal.BFS.Levelorder.Iterative.CodeFile<string>();
            var levelorderList = levelorder_Iterative.Traverse(node);

            foreach (var val in levelorderList)
            {
                Console.WriteLine(val);
            }

            Console.WriteLine("****************************************");
            Console.WriteLine();
            break;

        case "8":
            Console.WriteLine("Levelorder Recursive");
            var levelorder_Recursive = new TreeDataType.BinaryTree.Traversal.BFS.Levelorder.Recursive.CodeFile<string>();
            var levelorderListRecursive = levelorder_Recursive.Traverse(node);

            foreach (var val in levelorderListRecursive)
            {
                Console.WriteLine(val);
            }

            Console.WriteLine("****************************************");
            Console.WriteLine();
            break;

        case "9":
            Console.WriteLine("Count nodes Recursive");
            var countNodesRecursive = new TreeDataType.BinaryTree.CountNodesInBinaryTree.Recursive.CodeFile<string>();
            var count = countNodesRecursive.Count(node);

            Console.WriteLine(count);

            Console.WriteLine("****************************************");
            Console.WriteLine();
            break;

        case "10":
            Console.WriteLine("Count nodes Iterative");
            var countNodesIterative = new TreeDataType.BinaryTree.CountNodesInBinaryTree.Iterative.CodeFile<string>();
            var countIterative = countNodesIterative.Count(node);

            Console.WriteLine(countIterative);

            Console.WriteLine("****************************************");
            Console.WriteLine();
            break;

        case "11":
            Console.WriteLine("Height of tree using Recursion");
            var heightRecursion = new TreeDataType.BinaryTree.HeightInBinaryTree.Recursion.CodeFile<string>();
            var height = heightRecursion.CalculateHeight(node);

            Console.WriteLine(height);

            Console.WriteLine("****************************************");
            Console.WriteLine();
            break;

        case "12":
            Console.WriteLine("Count leaf nodes using Recursion");
            var leafNodesRecursion = new TreeDataType.BinaryTree.CountLeafNodes.Recursive.CodeFile<string>();
            var leafNodes = leafNodesRecursion.CountLeafNodes(node);

            Console.WriteLine(leafNodes);

            Console.WriteLine("****************************************");
            Console.WriteLine();
            break;

        case "13":
            Console.WriteLine("Count nodes with 2 children using Recursion");
            var nodesWith2ChildrenRecursion = new TreeDataType.BinaryTree.CountLeafNodes.Recursive.CodeFile<string>();
            var nodeCountWith2Children = nodesWith2ChildrenRecursion.CountNodesWith2Children(node);

            Console.WriteLine(nodeCountWith2Children);

            Console.WriteLine("****************************************");
            Console.WriteLine();
            break;

        case "14":
            Console.WriteLine("Count nodes with 1 children using Recursion");
            var nodesWith1ChildrenRecursion = new TreeDataType.BinaryTree.CountLeafNodes.Recursive.CodeFile<string>();
            var nodeCountWith1Children = nodesWith1ChildrenRecursion.CountNodesWith1Children(node);

            Console.WriteLine(nodeCountWith1Children);

            Console.WriteLine("****************************************");
            Console.WriteLine();
            break;

        case "15":
            Console.WriteLine("Insert in binary search tree using iteration");
            var bstIteration = new TreeDataType.BinarySearchTree.Types.BinarySearchTree();
            var i1 = bstIteration.Insert(30);
            var i2 = bstIteration.Insert(10);
            var i3 = bstIteration.Insert(15);
            var i4 = bstIteration.Insert(40);
            var i5 = bstIteration.Insert(45);
            var i6 = bstIteration.Insert(27);
            var i7 = bstIteration.Insert(12);
            Console.WriteLine("****************************************");
            Console.WriteLine();
            break;


        case "16":
            Console.WriteLine("Insert in binary search tree using recursion");
            var bstRecursion = new TreeDataType.BinarySearchTree.Types.BinarySearchTree();
            Node<int> root = null;
            root = bstRecursion.Insert(root, 30);
            root = bstRecursion.Insert(root, 10);
            root = bstRecursion.Insert(root, 15);
            root = bstRecursion.Insert(root, 40);
            root = bstRecursion.Insert(root, 45);
            root = bstRecursion.Insert(root, 27);
            root = bstRecursion.Insert(root, 12);


            Console.WriteLine("****************************************");
            Console.WriteLine();
            break;

        default:
            Console.WriteLine("Wrong choice");
            break;

    }

    choice = "a";

}