// See https://aka.ms/new-console-template for more information
using StringDataType.Challenges.ChangeCase;

Console.WriteLine("Changing case");
Console.WriteLine("*****************************************");
var changeCase = new CodeFile();
var output = changeCase.ChangeCase("RiTesh sHarMA5");
Console.WriteLine(output);

Console.WriteLine("Counting words and vowels");
Console.WriteLine("*****************************************");
var count = new StringDataType.Challenges.CountingWovelsAndWords.CodeFile();
count.Count("RiTesh sHarMA5  hello");


Console.WriteLine("Comparing strings");
Console.WriteLine("*****************************************");
var compare = new StringDataType.Challenges.Compare.CodeFile();
var compareOutput = compare.Compare("alpha", "alphA");
Console.WriteLine(compareOutput);


Console.WriteLine("Finding Duplicates");
Console.WriteLine("*****************************************");
var duplicates = new StringDataType.Challenges.Duplicate.CodeFile();
duplicates.FindDuplicate("AlphL");

Console.WriteLine("Checking if string is Anagram");
Console.WriteLine("*****************************************");
var anagram = new StringDataType.Challenges.Anagram.CodeFile();
var anagramOutput = anagram.CheckAnagram("decimal", "medical2");
if(anagramOutput)
{
    Console.WriteLine("Strings are anagram");
}
else
{
    Console.WriteLine("Strings are NOT anagram");
}

Console.WriteLine("*****************************************");

Console.WriteLine("Permutation");
Console.WriteLine("*****************************************");
var perm = new StringDataType.Challenges.Permutation.CodeFile();
perm.Permutation("ABCD", 0);
Console.WriteLine("*****************************************");
Console.WriteLine("*****************************************");

perm.Permutation2(new char[] { 'A', 'B', 'C', 'D' }, 0,  3);