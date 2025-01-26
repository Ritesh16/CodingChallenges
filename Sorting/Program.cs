// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var flag = true;
while (flag)
{
    var array = new int[] { 5, 6, 2, 12, 8, 11, 1, 9 };
    Console.WriteLine("Select the sorting algorithm. Sorting 5, 6, 2, 12, 8, 11, 1, 9");
    Console.WriteLine("1. Bubble Sort");
    Console.WriteLine("2. Insertion Sort");
    Console.WriteLine("3. Selection Sort");
    Console.WriteLine("4. Quick Sort");
    Console.WriteLine("9. Exit");

    var choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            var bubbleSort = new Sorting.BubbleSort.CodeFile();
            var sortedArray = bubbleSort.Sort(array);
            Console.WriteLine("Sorted array using Bubble Sort:");
            foreach (var item in sortedArray)
            {
                Console.Write(item + " ");
            }
            break;
        case 2:
            var insertionSort = new Sorting.InsertionSort.CodeFile();
            var sortedArray2 = insertionSort.Sort(array);
            Console.WriteLine("Sorted array using Insertion Sort:");
            foreach (var item in sortedArray2)
            {
                Console.Write(item + " ");
            }
            break;
        case 3:
            var selectionSort = new Sorting.SelectionSort.CodeFile();
            var sortedArray3 = selectionSort.Sort(array);
            Console.WriteLine("Sorted array using Selection Sort:");
            foreach (var item in sortedArray3)
            {
                Console.Write(item + " ");
            }
            break;
        case 4:
            var quickSort = new Sorting.QuickSort.CodeFile();
            var sortedArray4 = quickSort.Sort(array, 0 , array.Length - 1);

            Console.WriteLine("Sorted array using Quick Sort:");

            foreach (int i in sortedArray4)
            {
                Console.WriteLine(i);
            }
            break;

        case 9:
            flag = false;
            break;

        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid choice");
            Console.ForegroundColor = ConsoleColor.White;
            break;

    }

    Console.WriteLine();

}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Exiting...");
Console.ForegroundColor = ConsoleColor.White;