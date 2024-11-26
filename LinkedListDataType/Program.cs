// See https://aka.ms/new-console-template for more information
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

    Console.WriteLine("Press any key to continue or hit 'x' to quit.");

    choice = Console.ReadLine();
    LinkedListDataType.Types.LinkedList<int> linkedList = new LinkedListDataType.Types.LinkedList<int>();
    linkedList.Add(4);
    linkedList.Add(3);
    linkedList.Add(6);
    linkedList.Add(1);
    linkedList.Add(2);
    linkedList.Add(5);

    switch (choice)
    {
        case "1":
            //linkedList.Display();
            linkedList.Display_Recursively(linkedList.Head);
            break;

        case "2":
            Console.WriteLine("*********************************");
            Console.WriteLine("Printing Reverse Linked List");
            linkedList.Reverse(linkedList.Head);
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
            linkedList.Insert(6, 100);
            linkedList.Display();
            break;

        default:
            Console.WriteLine("Wrong Selection");
            break;

    }

    choice = "a";

}


