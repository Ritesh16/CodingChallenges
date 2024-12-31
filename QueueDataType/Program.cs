// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

QueueDataType.Types.Interfaces.IQueue<int> queue = new QueueDataType.Types.QueueArray<int>();
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Enqueue(4);
queue.Enqueue(5);
queue.Enqueue(6);
queue.Dequeue();
queue.Dequeue();
queue.Enqueue(7);
queue.Enqueue(8);
queue.Enqueue(9);
queue.Enqueue(10);
queue.Dequeue();
queue.Enqueue(11);
var output = queue.ToArray();
Show(output);


void Show(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}