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
    Console.WriteLine("5. Merge Sort Recursive");
    Console.WriteLine("6. Merge Sort Iterative");
    Console.WriteLine("7. Count Sort");
    Console.WriteLine("8. Bucket Sort");
    Console.WriteLine("9. Radix Sort");
    Console.WriteLine("10. Shell Sort");
    Console.WriteLine("99. Exit");

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
        case 5:
            var mergeSort = new Sorting.MergeSort.Recursive.CodeFile();
            var sortedArray5 = mergeSort.Sort(array);

            Console.WriteLine("Sorted array using Merge Sort:");

            foreach (int i in sortedArray5)
            {
                Console.WriteLine(i);
            }
            break;

        case 6:
            var mergeSortIterative = new Sorting.MergeSort.Iterative.CodeFile();
            mergeSortIterative.Sort(array);

            Console.WriteLine("Sorted array using Merge Sort Iterative:");

            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
            break;

        case 7:
            var countSort = new Sorting.CountSort.CodeFile();
            var sortedAray6 = countSort.Sort(array);

            Console.WriteLine("Sorted array using Count Sort");

            foreach (int i in sortedAray6)
            {
                Console.WriteLine(i);
            }
            break;
        case 8:
            var bucketSort = new Sorting.BucketSort.CodeFile();
            var sortedAray7 = bucketSort.Sort(array);

            Console.WriteLine("Sorted array using Bucket Sort");

            foreach (int i in sortedAray7)
            {
                Console.WriteLine(i);
            }
            break;
        case 9:
            var radixSortArray = new int[] { 66, 75, 2, 802, 170, 24, 90, 45 };
            var radixSort = new Sorting.RadixSort.CodeFile();
            var sortedAray8 = radixSort .Sort(radixSortArray);

            Console.WriteLine("Sorted array using Radix Sort");

            foreach (int i in sortedAray8)
            {
                Console.WriteLine(i);
            }
            break;

        case 10:
            var shellSort = new Sorting.ShellSort.CodeFile();
            var sortedAray9 = shellSort.Sort(array);

            Console.WriteLine("Sorted array using Shell Sort");

            foreach (int i in sortedAray9)
            {
                Console.WriteLine(i);
            }
            break;

        case 99:
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