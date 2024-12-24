// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
StackDataType.Types.Interfaces.IStack<int> stack = new StackDataType.Types.StackUsingLinkedList();
stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Push(4);
stack.Push(5);
stack.Push(6);
Console.WriteLine($"Size: {stack.Count}");

var top = stack.Peek();

Console.WriteLine($"Top : {top}");

var pop = stack.Pop();
Console.WriteLine($"Pop : {pop} , Size: {stack.Count}");
