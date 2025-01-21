// See https://aka.ms/new-console-template for more information
using HeapDataType.Types;
using HeapDataType.Types.Interfaces;

Console.WriteLine("Hello, World!");

IHeap heap = new MaxHeap(10);
heap.Insert(40);
heap.Insert(35);
heap.Insert(30);
heap.Insert(15);
heap.Insert(10);
heap.Insert(25);
heap.Insert(5);


Console.WriteLine("Hello, World!");