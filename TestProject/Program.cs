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

// string[] arr = new string[3];
// arr[0] = "helllo";
// arr[1] = "eeded";
// arr[5] = "ded";

// System.Console.WriteLine(arr[0]);
// System.Console.WriteLine(arr[1]);

// string[] arr1 = ["helo", "raw", "tent"];
// System.Console.WriteLine(arr1[0]);
// System.Console.WriteLine(arr1.Length);

// foreach(string i in arr1){
    // System.Console.WriteLine(i);
// }

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

// int value1 = (int)1.5m; // upcast
// int value2 = Convert.ToInt32(1.5m); // downcast
// System.Console.WriteLine($" {value1} {value2}");

// string[] values = ["12.3", "45", "ABC", "11", "DEF"];
// string message = "";
// decimal total = 0;
// foreach(string i in values){

//     decimal num = 0;
//     if(decimal.TryParse(i, out num)){
//         total += num;
//     }else{
//         message += i; 
//     }
// }
// System.Console.WriteLine($"{total} {message}");

// methods

// System.Console.WriteLine(sum(1,2));

// int sum(int a, int b){
//     return a+b;
// }

// int sumOfArr(int[] arr){
//     int ans = 0;
//     foreach(int i in arr) ans += i;
//     return ans;
// }

// int[] arr = [1,2,3,4,3,2,1];
// System.Console.WriteLine(sumOfArr(arr));

// string str = "hello";
// int[] arr = [1,2,3,5];
// strChange(str);
// arrChange(arr);
// System.Console.WriteLine(arr[3]);
// System.Console.WriteLine(str);

// void arrChange(int[] arr){
//     arr[3] = 4;
// }
// void strChange(string str){
//     str = "bye";
//     return;
// }

printInfo(id:1, age:19, name:"swapnil", gender:"male");

void printInfo(int id, string name, int age, string gender="prefer not to say"){
    System.Console.WriteLine($"student's name is {name}, id-{id}, age-{age}");
    System.Console.WriteLine($"gender {gender}");
}