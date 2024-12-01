// See https://aka.ms/new-console-template for more information
using LinkedListDataType.Types;

var choice = "a";

while (choice == "a")
{
    Console.WriteLine();
    Console.WriteLine("*****************************************");
    Console.WriteLine("Linked List. Please choose the following.");
    Console.WriteLine("1. Display linked list");
    Console.WriteLine("2. Print Linked List in Reverse");
    Console.WriteLine("3. Sum Linked List");
    Console.WriteLine("4. Total Elements in List");
    Console.WriteLine("5. Max Element in List");
    Console.WriteLine("6. Max Element in List");
    Console.WriteLine("7. Add first in the List");
    Console.WriteLine("8. Add last in the List");
    Console.WriteLine("9. Insert in index List");
    Console.WriteLine("10.Reverse Linked List");
    Console.WriteLine("11.Delete from Linked List");
    Console.WriteLine("12.Has loop in Linked List");
    Console.WriteLine("13.Merge 2 linked lists");
    Console.WriteLine("14.Middle of linked list");
    Console.WriteLine("15.Intersection of linked list");
    Console.WriteLine("15.Circular linked list");

    Console.WriteLine("Press any key to continue or hit 'x' to quit.");

    choice = Console.ReadLine();
    LinkedListDataType.Types.LinkedList<int> linkedList = new LinkedListDataType.Types.LinkedList<int>();
    linkedList.Add(1);
    linkedList.Add(2);
    linkedList.Add(3);
    linkedList.Add(4);
    linkedList.Add(5);
    linkedList.Add(6);
    linkedList.Add(7);
    linkedList.Add(8);

    switch (choice)
    {
        case "1":
            //linkedList.Display();
            linkedList.Display_Recursively(linkedList.Head);
            break;

        case "2":
            Console.WriteLine("*********************************");
            Console.WriteLine("Printing Reverse Linked List");
            linkedList.PrintReverse(linkedList.Head);
            break;

        case "3":
            Console.WriteLine("*********************************");
            Console.WriteLine("Sum Linked List");
            var sum = linkedList.Sum();
            Console.WriteLine($"{sum}");
            break;

        case "4":
            Console.WriteLine("*********************************");
            Console.WriteLine("Total elements in linked list");
            var total = linkedList.Count();
            Console.WriteLine($"{total}");
            break;

        case "5":
            Console.WriteLine("*********************************");
            Console.WriteLine("MAX element in linked list");
            var max = linkedList.Max();
            Console.WriteLine($"{max}");
            break;

        case "6":
            Console.WriteLine("*********************************");
            Console.WriteLine("MIN element in linked list");
            var min = linkedList.Min();
            Console.WriteLine($"{min}");
            break;

        case "7":
            Console.WriteLine("*********************************");
            Console.WriteLine("Add first element in linked list");
            var addFirst = linkedList.AddFirst(100);
            linkedList.Display();
            break;

        case "8":
            Console.WriteLine("*********************************");
            Console.WriteLine("Add last element in linked list");
            var addLast = linkedList.AddLast(100);
            linkedList.Display();
            break;

        case "9":
            Console.WriteLine("*********************************");
            Console.WriteLine("Add at index in linked list");
            linkedList.Insert(9, 100);
            linkedList.Display();
            break;

        case "10":
            Console.WriteLine("*********************************");
            Console.WriteLine("Reversing a linked list");
            linkedList.Reverse_Recursively(linkedList.Head, null);
            linkedList.Display();

            Console.WriteLine("*********************************");
            Console.WriteLine("*********************************");
            break;

        case "11":
            Console.WriteLine("*********************************");
            Console.WriteLine("Deleting from linked list");
            linkedList.Delete(6);
            linkedList.Display();

            Console.WriteLine("*********************************");
            Console.WriteLine("*********************************");
            break;

        case "12":
            Console.WriteLine("*********************************");
            Console.WriteLine("Checking for loop in Linked List");
            var node = new Node<int>(1);
            var second = new Node<int>(2);
            second.Next = new Node<int>(3);
            node.Next = second;
            var fourth = new Node<int>(4);
            fourth.Next = second;

            second.Next.Next = fourth;

            var hasLoop = linkedList.HasLoop(node);
            if (hasLoop)
            {
                Console.WriteLine("Linked list has loop");
            }
            else
            {
                Console.WriteLine("Linked list does not have loop");
            }


            Console.WriteLine("*********************************");
            Console.WriteLine("*********************************");
            break;

        case "13":
            Console.WriteLine("*********************************");
            Console.WriteLine("Merging linked list");
            var mergeList1 = new Node<int>(2);
            mergeList1.Next = new Node<int>(8);
            mergeList1.Next.Next = new Node<int>(11);
            mergeList1.Next.Next.Next = new Node<int>(15);
            mergeList1.Next.Next.Next.Next = new Node<int>(16);

            var mergeList2 = new Node<int>(4);
            mergeList2.Next = new Node<int>(9);
            mergeList2.Next.Next = new Node<int>(10);

            Console.ForegroundColor = ConsoleColor.Green;

            var mergedList = linkedList.Merge(mergeList1, mergeList2);
            while (mergedList != null)
            {
                Console.WriteLine(mergedList.Value);
                mergedList = mergedList.Next;
            }


            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("*********************************");
            break;

        case "14":
            Console.WriteLine("*********************************");
            Console.WriteLine("Merging linked list");
            Console.ForegroundColor = ConsoleColor.Green;

            var middle = linkedList.Middle(linkedList.Head);

            Console.WriteLine($"Middle node is {middle.Value}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("*********************************");
            break;

        case "15":
            Console.WriteLine("*********************************");
            Console.WriteLine("Intersection of linked list");
            var intersectionList1 = new Node<int>(1);
            intersectionList1.Next = new Node<int>(12);
            intersectionList1.Next.Next = new Node<int>(10);
            intersectionList1.Next.Next.Next = new Node<int>(5);

            var intersectionNode = new Node<int>(2);
            intersectionNode.Next = new Node<int>(7);
            intersectionNode.Next.Next = new Node<int>(8);

            intersectionList1.Next.Next.Next.Next = intersectionNode;

            var intersectionList2 = new Node<int>(6);
            intersectionList2.Next = new Node<int>(100);
            intersectionList2.Next.Next = intersectionNode;


            Console.ForegroundColor = ConsoleColor.Green;

            var intersection = linkedList.Intersection(intersectionList1, intersectionList2);

            Console.WriteLine($"Intersection node is {intersection.Value}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("*********************************");
            break;

        case "16":
            Console.WriteLine("*********************************");
            Console.WriteLine("Circular linked list");
            LinkedListDataType.Types.CircularLinkedList<int> circularLinkedList = new LinkedListDataType.Types.CircularLinkedList<int>();
            circularLinkedList.Add(0);
            circularLinkedList.Add(1);
            circularLinkedList.Add(2);
            circularLinkedList.AddLast(3);
            circularLinkedList.AddLast(4);

            circularLinkedList.Insert(5, 10);

            var head = circularLinkedList.Head;
            var tail = circularLinkedList.Tail;
            do
            {
                Console.WriteLine(head.Value);
                head = head.Next;
            }
            while (head != tail.Next);


            break;

        default:
            Console.WriteLine("Wrong Selection");
            break;

    }

    choice = "a";

}


