// Задача 54: 
// Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.


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

void Sort2DArr(int[,] arr)
{
    int temp = 0;
    int count = arr.GetLength(1) + 1; 
    while (count > 0)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1) - 1; j++)
            {
                // Sorting though with ol' reliable bubble sorting method
                if (arr[i, j] < arr[i, j + 1])
                {
                    temp = arr[i, j];
                    arr[i, j] = arr[i, j + 1];
                    arr[i, j + 1] = temp;
                }
            }
        }
        count--;
    }
}

Console.Clear();
Console.WriteLine("Please enter the data to generate a new matrix.");
int inRow = ReadData("Enter the desired amount of rows: ");
int inCol = ReadData("Enter the desired amount of columns: ");
int[,] testArr = Gen2DArray(inRow, inCol, 10, 100);
Print2DArr(testArr);
Console.WriteLine();

Sort2DArr(testArr);
Print2DArr(testArr);
