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

int [] arrInt = [1,3,4,2,4,5,3,2,3,4,3,1];
int sum = 0;
foreach(int i in arrInt) {sum += i;}
System.Console.WriteLine(sum);