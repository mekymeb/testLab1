// See https://aka.ms/new-console-template for more information
using static System.Console;

Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, Meky");
Console.WriteLine("Version: 7.0.2");
Console.WriteLine("This is a test");
string text = System.IO.File.ReadAllText("text.txt");
Console.WriteLine(text);

//This is Visual Studio
//This is Kean

Console.WriteLine("Hello, Meky");
Console.WriteLine("Version: 7.0.2");

string[] names; // can reference any size array of strings

// allocating memory for four strings in an array
names = new string[4];

// storing items at index positions
names[0] = "Kim";
names[1] = "Sasha";
names[2] = "Joey";
names[3] = "Mike";

string[] names2 = new[] { "Kim", "Sasha", "Joey", "Mike" };

// looping through the names
for (int i = 0; i < names2.Length; i++)
{
  // output the item at index position i
  WriteLine(names2[i]);
}

string[,] grid1 = new[,] // two dimensions
{
  { "Avocado", "Best", "Grape", "Duration" },
  { "Advanatge", "Brother", "Crust", "Disney" },
  { "Armadillo", "Banana", "Cap", "Dallas" }
};

WriteLine($"Lower bound of the first dimension is: {grid1.GetLowerBound(0)}");
WriteLine($"Upper bound of the first dimension is: {grid1.GetUpperBound(0)}");
WriteLine($"Lower bound of the second dimension is: {grid1.GetLowerBound(1)}");
WriteLine($"Upper bound of the second dimension is: {grid1.GetUpperBound(1)}");

for (int row = 0; row <= grid1.GetUpperBound(0); row++)
{
  for (int col = 0; col <= grid1.GetUpperBound(1); col++)
  {
    WriteLine($"Row {row}, Column {col}: {grid1[row, col]}");
  }
}

// alternative syntax
string[,] grid2 = new string[3,4]; // allocate memory
grid2[0, 0] = "Avocado"; // assign string values
// and so on
grid2[2, 3] = "Dallas";

string[][] jagged = new[] // array of string arrays
{
  new[] { "Avocado", "Best", "Grape" },
  new[] { "Advantage", "Brother", "Crust", "Disney" },
  new[] { "Armadillo", "Banana" }
};

WriteLine("Upper bound of array of arrays is: {0}",
  jagged.GetUpperBound(0));

for (int array = 0; array <= jagged.GetUpperBound(0); array++)
{
  WriteLine("Upper bound of array {0} is: {1}",
    arg0: array,
    arg1: jagged[array].GetUpperBound(0));
}

for (int row = 0; row <= jagged.GetUpperBound(0); row++)
{
  for (int col = 0; col <= jagged[row].GetUpperBound(0); col++)
  {
    WriteLine($"Row {row}, Column {col}: {jagged[row][col]}");
  }
}

// Pattern matching with arrays

int[] sequentialNumbers = new int[] {11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
int[] oneTwoNumbers = new int[] { 1, 2 };
int[] oneTwoTenNumbers = new int[] { 1, 2, 10 };
int[] oneTwoThreeTenNumbers = new int[] { 1, 2, 5, 10 };
int[] primeNumbers = new int[] { 31, 37, 41, 43, 47, 53, 59, 61, 67, 71 };
int[] fibonacciNumbers = new int[] { 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711, 28657 };
int[] emptyNumbers = new int[] { };
int[] threeNumbers = new int[] { 3, 9, 5 };
int[] sixNumbers = new int[] { 8, 3, 7, 5, 6, 14 };

WriteLine($"{nameof(sequentialNumbers)}: {CheckSwitch(sequentialNumbers)}");
WriteLine($"{nameof(oneTwoNumbers)}: {CheckSwitch(oneTwoNumbers)}");
WriteLine($"{nameof(oneTwoTenNumbers)}: {CheckSwitch(oneTwoTenNumbers)}");
WriteLine($"{nameof(oneTwoThreeTenNumbers)}: {CheckSwitch(oneTwoThreeTenNumbers)}");
WriteLine($"{nameof(primeNumbers)}: {CheckSwitch(primeNumbers)}");
WriteLine($"{nameof(fibonacciNumbers)}: {CheckSwitch(fibonacciNumbers)}");
WriteLine($"{nameof(emptyNumbers)}: {CheckSwitch(emptyNumbers)}");
WriteLine($"{nameof(threeNumbers)}: {CheckSwitch(threeNumbers)}");
WriteLine($"{nameof(sixNumbers)}: {CheckSwitch(sixNumbers)}");

static string CheckSwitch(int[] values) => values switch
{
  [] => "Empty array",
  [1, 2, _, 10] => "Contains 1, 2, any single number, 10.",
  [1, 2, .., 10] => "Contains 1, 2, any range including empty, 10.",
  [1, 2] => "Contains 1 then 2.",
  [int item1, int item2, int item3] => 
    $"Contains {item1} then {item2} then {item3}.",
  [0, _] => "Starts with 0, then one other number.",
  [0, ..] => "Starts with 0, then any range of numbers.",
  [2, .. int[] others] => $"Starts with 2, then {others.Length} more numbers.",
  [..] => "Any items in any order.",
};
