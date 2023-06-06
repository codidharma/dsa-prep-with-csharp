// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//integer arrays

#region Uni dimensional array
var integerArray = new int[] { 11, 12, 13, 14, 15 };

//For a single dimension array, the GetUpperBound and length will return the same result. But in case of multidimensinal array
// We will have to use the GetUpperBound(int dimension) to get the upper bound of the last element, we can use GetLength(int dimension)
//To get the length of a particular dimension

Console.WriteLine($"Array type is {integerArray.GetType()}");
Console.WriteLine($"Array Upper bound is {integerArray.GetUpperBound(0)}");
Console.WriteLine($"Array Lower Bound is {integerArray.GetLowerBound(0)}"); 
Console.WriteLine($"The length of the array is {integerArray.Length}");

//Looping through the array using for loop
for (int i = 0; i <= integerArray.GetUpperBound(0); i++)
{
    Console.WriteLine($"Accessing element at index {i} with value {integerArray.GetValue(i)} using for loop");   
}

//Looping through the array using foreach


foreach (var item in integerArray)
{
    Console.WriteLine($"Accessing element at index {item}");

}

//Looping through array using enumerator
Console
.WriteLine($"The count of the elements in array using the tryGEtEnumeratorCount is {integerArray.TryGetNonEnumeratedCount(out int count)} {count}");

var arrayEnumerator = integerArray.GetEnumerator();
int looper = 0;
while (arrayEnumerator.MoveNext() && arrayEnumerator.Current is not null)
{
    Console.WriteLine($"Current Element is {arrayEnumerator.Current}");
    Console.WriteLine($"Index is {looper++}");

}

#endregion

#region 2D Arrays

//Create and set values of the array in simple way
var twoDArraySimple = new int[,] { { 1, 2, 3 }, { 3, 4, 3 },{ 5, 6, 3 } };

for (int i = twoDArraySimple.GetLowerBound(0); i <= twoDArraySimple.GetUpperBound(0); i++)
for (int j = twoDArraySimple.GetLowerBound(1); j <= twoDArraySimple.GetUpperBound(1); j++)
Console.WriteLine($"Printing element at {i},{j} with value {twoDArraySimple.GetValue(i, j)}");

//Create and set array elements using functions


var twoDArray = Array.CreateInstance(typeof(int), 3, 3);


Console.WriteLine($"First Dimesnion upperbound {twoDArray.GetUpperBound(0)}");
Console.WriteLine($"Second Dimesnion upperbound {twoDArray.GetUpperBound(1)}");

for (int i = twoDArray.GetLowerBound(0); i <= twoDArray.GetUpperBound(0); i++)
{
    for (int j = twoDArray.GetLowerBound(1); j <= twoDArray.GetUpperBound(1); j++)
    {
        Console.WriteLine($"{i}{j}");
        var randomValue = Random.Shared.Next();
        Console.WriteLine($"Setting value {randomValue} at {i} {j}");
        twoDArray.SetValue(randomValue, i, j);

    }

}

// for (int i = twoDArray.GetLowerBound(0); i <= twoDArray.GetUpperBound(0); i++)
// for (int j = twoDArray.GetLowerBound(1); i <= twoDArray.GetUpperBound(1); j ++)
//         //twoDArray.SetValue((i + j) * 3, i, j);
//         Console.WriteLine($"{i}{j}");

for (int i = twoDArray.GetLowerBound(0); i <= twoDArray.GetUpperBound(0); i++)
{
    for (int j = twoDArray.GetLowerBound(1); j <= twoDArray.GetUpperBound(1); j++)
    {
        Console.WriteLine($"Element at {i}{j} is {twoDArray.GetValue(i, j)}"); 
    }

}
#endregion

#region Jagged Arrays

var jaggedArray = new int[2][];

for (int i = jaggedArray.GetLowerBound(0); i <= jaggedArray.GetUpperBound(0); i++)
{
    var arrayLength = Random.Shared.Next(1, 3);
    var array = new int[arrayLength];

    Console.WriteLine($"Creating an array of {arrayLength}");

    for (int j = 0; j <= arrayLength - 1; j++)
    {
        array.SetValue(Random.Shared.Next(100), j);
    }
    jaggedArray.SetValue(array, i);

}

//Printing Elements of the jagged Array

for (int i = jaggedArray.GetLowerBound(0); i <= jaggedArray.GetUpperBound(0); i++)
{
    for (int j = jaggedArray[i].GetLowerBound(0); j <= jaggedArray[i].GetUpperBound(0); j++)
    {
        Console.WriteLine($"Element in {i} row array index {j} with value {jaggedArray[i].GetValue(j)}");

    }




}
#endregion

Console.ReadKey();