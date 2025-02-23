using ArrayDataType.Types;
using ArrayDataType.Challenges.TwoSum;

using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;


var array = new int[] { 3, 2, 7, 9, 4 };
var target = 6;
var codeFile = new CodeFile();
var output = codeFile.TwoSum(array, target);
Console.WriteLine($"Output: [{output[0]}, {output[1]}]");