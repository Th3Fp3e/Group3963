// Задача №53
// Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.


int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[,] Gen2DArray (int rows, int col, int max)
{
    int[,] arr = new int[rows, col];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(10, max+1);
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

void Change2DArray(int[,] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        temp = arr[0, i];
        arr[0, i] = arr[arr.GetLength(0)-1, i];
        arr[arr.GetLength(0)-1, i] = temp;
    }
}

Console.Clear();
Console.WriteLine("Please enter the data to generate a new matrix.");
int inRow = ReadData("Enter the desired amount of rows: ");
int inCol = ReadData("Enter the desired amount of columns: ");
int[,] testArr = Gen2DArray(inRow, inCol, 100);
Console.WriteLine();
Console.WriteLine("Your generated matrix:");
Print2DArr(testArr);
Console.WriteLine();

Change2DArray(testArr);
Console.WriteLine("The changed matrix:");
Print2DArr(testArr);