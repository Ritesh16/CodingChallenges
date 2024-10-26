using ArrayDataType.Types;

var array = new ArrayDataType.Types.Array();

array.Add(1);
array.Add(2);
array.Add(3);
array.Add(4);

array.Add(5);
array.Add(6);
array.Add(7);
array.Add(8);
array.Add(9);
array.Add(10);
array.Add(11);
array.Add(12);

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