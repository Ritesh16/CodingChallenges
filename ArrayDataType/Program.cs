using ArrayDataType.Challenges.ArrangeNegativeToLeft;
using ArrayDataType.Types;
using System.Net.Http.Headers;

var array = new ArrayDataType.Types.Array();

array.Add(1);
array.Add(2);
array.Add(3);
array.Add(4);

array.Add(5);


//Console.WriteLine("Items in array:");
//foreach (var item in array)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine("******************************");

//array.Insert(0, 100);

//Console.WriteLine("Items in array after insert:");

//for (var i = 0; i< array.Length; i++)
//{
//    Console.WriteLine(array[i]);
//}

//Console.WriteLine($"Length : {array.Length}");
//Console.WriteLine("******************************");

//array.Delete(50);
//Console.WriteLine("Items in array after delete:");
//for (var i = 0; i < array.Length; i++)
//{
//    Console.WriteLine(array[i]);
//}

//Console.WriteLine($"Length : {array.Length}");
//Console.WriteLine("******************************");
var output = array.Search(11);

Console.WriteLine(output);

Console.WriteLine("******************************");
Console.WriteLine($"Sum : {array.Sum()}");
Console.WriteLine($"Avg : {array.Avg()}");
Console.WriteLine($"Max : {array.Max()}");
Console.WriteLine($"Min : {array.Min()}");

Console.WriteLine("******************************");
Console.WriteLine("Reverse array :");
var reversedArray = array.Reverse();
foreach (var item in reversedArray)
{
    Console.WriteLine(item);
}
Console.WriteLine("******************************");
Console.WriteLine("Right shift :");
array.RightShift();
array.RightShift();
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}

Console.WriteLine("******************************");
Console.WriteLine("Sorted Array :");
var sortedArray = new SortedArray();
sortedArray.Add(12);
sortedArray.Add(10);
sortedArray.Add(10);
sortedArray.Add(27);
sortedArray.Add(5);
sortedArray.Add(1);
sortedArray.Add(-1);
sortedArray.Add(29);
sortedArray.Add(0);

for (int i = 0; i < sortedArray.Length; i++)
{
    Console.WriteLine(sortedArray[i]);
}

Console.WriteLine("***********************************");
Console.WriteLine("Arrange Negatives :");
var codeFile = new CodeFile();
var input = new int[] { 2, 3, -1, -5, -20, 7, 8, -6, 0, 29, 22 };

var outputArrangeNegatives = codeFile.Execute(input);

for (int i = 0; i < outputArrangeNegatives.Length; i++)
{
    Console.WriteLine(outputArrangeNegatives[i]);
}


Console.WriteLine("***********************************");
Console.WriteLine("Merge sorted arrays :");
var sortedArray1 = new SortedArray();
sortedArray1.Add(1);
sortedArray1.Add(3);
sortedArray1.Add(5);
sortedArray1.Add(7);

var sortedArray2 = new SortedArray();
sortedArray2.Add(2);
sortedArray2.Add(4);
sortedArray2.Add(6);
sortedArray2.Add(8);
sortedArray2.Add(10);
sortedArray2.Add(12);

var mergedSortedArray = sortedArray1.Merge(sortedArray1.ToArray(), sortedArray2.ToArray());
for (int i = 0; i < mergedSortedArray.Length; i++)
{
    Console.WriteLine(mergedSortedArray[i]);
}