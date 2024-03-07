// Random dice = new Random();
// int roll = dice.Next(1,7);
// int roll2 = dice.Next();
// int roll3 = dice.Next(100);
// Console.WriteLine(roll);
// Console.WriteLine(roll2);
// Console.WriteLine(roll3);

// int x1 = 10;
// int x2 = 12;
// int maxVal = Math.Max(x1,x2);
// Console.WriteLine(maxVal);

string[] arr = new string[3];
arr[0] = "helllo";
arr[1] = "eeded";
// arr[5] = "ded";

// System.Console.WriteLine(arr[0]);
// System.Console.WriteLine(arr[1]);

string[] arr1 = ["helo", "raw", "tent"];
// System.Console.WriteLine(arr1[0]);
// System.Console.WriteLine(arr1.Length);

foreach(string i in arr1){
    // System.Console.WriteLine(i);
}

// int [] arrInt = [1,3,4,2,4,5,3,2,3,4,3,1];
// int sum = 0;
// foreach(int i in arrInt) {sum += i;}
// System.Console.WriteLine(sum);

// System.Console.WriteLine("a" == "a");
// System.Console.WriteLine("a" == "a ");

// string pangram = "The quick brown fox jumps over the lazy dog.";
// System.Console.WriteLine(!pangram.Contains("fox"));

// conditional operator
// int age = 18;
// bool validVote = age >= 18 ? true : false;
// System.Console.WriteLine($"you can vote - {validVote}");

// int value;
// System.Console.WriteLine(value);
// value = 10;
// if(true){
//     System.Console.WriteLine(value);
// }
// System.Console.WriteLine(value);

// max min ranges
// System.Console.WriteLine($"sbyte: {sbyte.MinValue} to {sbyte.MaxValue}");
// System.Console.WriteLine($"int: {int.MinValue} to {int.MaxValue}");
// System.Console.WriteLine($"long: {long.MinValue} to {long.MaxValue}");
// System.Console.WriteLine($"uint: {uint.MinValue} to {uint.MaxValue}");
// System.Console.WriteLine($"ulong: {ulong.MinValue} to {ulong.MaxValue}");

// System.Console.WriteLine($"float: {float.MinValue} to {float.MaxValue}");
// System.Console.WriteLine($"double: {double.MinValue} to {double.MaxValue}");
// System.Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue}");

// The term widening conversion means that you're attempting to convert a value from a data 
// type that could hold less information to a data type that can hold more information

int value1 = (int)1.5m; // upcast
int value2 = Convert.ToInt32(1.5m); // downcast
System.Console.WriteLine($" {value1} {value2}");