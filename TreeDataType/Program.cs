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

    Console.WriteLine("Press any key to continue or hit 'x' to quit.");

    choice = Console.ReadLine();

    var node = new Node<string>("A");

    var leftTree = new Node<string>("B");
    leftTree.Left = new Node<string>("C");
    leftTree.Right = new Node<string>("D");

    node.Left = leftTree;

    var rightTree = new Node<string>("E");
    rightTree.Left = new Node<string>("F");
    rightTree.Right = new Node<string>("G");
    rightTree.Right.Left = new Node<string>("H");

    node.Right = rightTree;

    switch (choice)
    {
        case "1":
            Console.WriteLine("****************************************");
            Console.WriteLine("Preorder Recursive");
            var preorder_Recursive = new TreeDataType.BinaryTree.Traversal.Preorder.Recursive.CodeFile<string>();
            preorder_Recursive.Traverse(node);

            Console.WriteLine("****************************************");
            Console.WriteLine();
            break;

        case "2":
            Console.WriteLine("****************************************");
            Console.WriteLine("Preorder Iterative");
            var preorder_Iterative = new TreeDataType.BinaryTree.Traversal.Preorder.Iterative.CodeFile<string>();
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
            var inorder_Recursive = new TreeDataType.BinaryTree.Traversal.Inorder.Recursive.CodeFile<string>();
            inorder_Recursive.Traverse(node);

            Console.WriteLine("****************************************");
            Console.WriteLine();
            break;

        case "4":
            Console.WriteLine("Inorder Iterative");
            var inorder_Iterative = new TreeDataType.BinaryTree.Traversal.Inorder.Iterative.CodeFile<string>();
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
            var postorder_Recursive = new TreeDataType.BinaryTree.Traversal.Postorder.Recursive.CodeFile<string>();
            postorder_Recursive.Traverse(node);
            Console.WriteLine("****************************************");
            Console.WriteLine();
            break;

        case "6":
            Console.WriteLine("Postorder Iterative");
            var postorder_Iterative = new TreeDataType.BinaryTree.Traversal.Postorder.Iterative.CodeFile<string>();
            var postorderList = postorder_Iterative.Traverse(node);

            foreach (var val in postorderList)
            {
                Console.WriteLine(val);
            }

            Console.WriteLine("****************************************");
            Console.WriteLine();
            break;

        default:
            Console.WriteLine("Wrong choice");
            break;

    }

    choice = "a";

}