// See https://aka.ms/new-console-template for more information

using Recursion.TaylorSeries;

var ob = new CodeFile();
//var val = sumNNumbers.Sum(4);
//var val2 = sumNNumbers.Sum_Iterative(4);
//Console.WriteLine("Using Recursion...");
//Console.WriteLine(val);

//Console.WriteLine("Using Iterative...");

//var factorial = new CodeFile();
//var fact1 = factorial.Factorial(5);
//var fact2 = factorial.Factorial_Iterative(5);


//var val1 = ob.Power_Efficient(2, 5);
var val = ob.TaylorSeries(4,1);

var val1 = ob.TaylorSeries_Horner(2, 10);


Console.WriteLine($"Using recursion : {val}, Using Horner solution: {val1}");

