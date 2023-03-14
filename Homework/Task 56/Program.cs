// Задача 56: 
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.

int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[,] Gen2DArray(int rows, int col, int min, int max)
{
    int[,] arr = new int[rows, col];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(min, max + 1);
        }
    }
    return arr;
}

void Print2DArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


// A simple method for calculating the sum of elements in a specific row
int RowElemSum(int[,] arr, int row)
{
    int sum = 0;
    // There's no need for a second "if" installment, since we're only calculating the sum of one row
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum += arr[i, row];
    }
    return sum;
}

int MinRowSum(int[,] arr, int rows)
{
    // We'll create an internal array of sums of all rows in the generated matrix
    int[] rowSums = new int[rows];
    for (int i = 0; i < rowSums.Length; i++)
    {
        rowSums[i] = RowElemSum(arr, i);
    }

    // And then find, which row has the lowest through the internal array index 
    int minSumRow = 0;
    for (int j = 1; j < rowSums.Length; j++)
    {
        if (rowSums[j-1] > rowSums[j]) minSumRow = j;
    }
    return minSumRow;
}

Console.Clear();
Console.WriteLine("Please enter the data to generate a new matrix.");
int inRow = ReadData("Enter the desired amount of rows: ");
int inCol = ReadData("Enter the desired amount of columns: ");
int[,] testArr = Gen2DArray(inRow, inCol, 1, 10);
Print2DArr(testArr);
Console.WriteLine();


// Tryouts for myself, pay no mind...
// int sum1 = RowElemSum(testArr, 0);
// Console.WriteLine(sum1);
// int sum2 = RowElemSum(testArr, 1);
// Console.WriteLine(sum2);
// int sum3 = RowElemSum(testArr, 2);
// Console.WriteLine(sum3);
// int sum4 = RowElemSum(testArr, 3);
// Console.WriteLine(sum4);
// int sum5 = RowElemSum(testArr, 4);
// Console.WriteLine(sum5);

int minRow = MinRowSum(testArr, inRow);
Console.WriteLine($"The biggest sum of elements is {minRow}");