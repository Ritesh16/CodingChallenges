// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

LinkedListDataType.Types.LinkedList<int> linkedList = new LinkedListDataType.Types.LinkedList<int>();
linkedList.Add(4);
linkedList.Add(3);
linkedList.Add(6);
linkedList.Add(1);
linkedList.Add(2);
linkedList.Add(5);
//linkedList.Display();
linkedList.Display_Recursively(linkedList.Head);
Console.WriteLine("*********************************");
Console.WriteLine("Reverse Linked List");

linkedList.Reverse(linkedList.Head);
Console.WriteLine("*********************************");
Console.WriteLine("Sum Linked List");
var sum = linkedList.Sum();
Console.WriteLine($"{sum}");


Console.WriteLine("*********************************");
Console.WriteLine("Total elements in linked list");
var total = linkedList.Count();
Console.WriteLine($"{total}");

Console.WriteLine("*********************************");
Console.WriteLine("MAX element in linked list");
var max = linkedList.Max();
Console.WriteLine($"{max}");

Console.WriteLine("*********************************");
Console.WriteLine("MIN element in linked list");
var min = linkedList.Min();
Console.WriteLine($"{min}");
