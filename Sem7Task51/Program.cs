// Задача №51
// Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[,] Gen2DArray(int countRows, int countColumn, int min, int max)
{
    int[,] arr = new int[countRows, countColumn];
    for (int i = 0; i < countRows; i++)
    {
        for (int j = 0; j < countColumn; j++)
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
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int CountMainDiag(int[,] arr)
{
    int result = 0;


    // int min = arr.GetLength(0);
    // if (arr.GetLength(0) > arr.GetLength(1)) min = arr.GetLength(1);
    int min = arr.GetLength(0) > arr.GetLength(1) ? arr.GetLength(1) : arr.GetLength(0);

    for (int j = 0; j < min; j++)
    {
        result += arr[j, j];
    }

    return result;
}


Console.Clear();
int rows = ReadData("Enther the desired number of rows: ");
int col = ReadData("Eneter the desired number of columns: ");
int[,] testArray = Gen2DArray(rows, col, 10, 99);
Print2DArr(testArray);
Console.WriteLine();
int result = CountMainDiag(testArray);
Console.WriteLine($"The sum of elements on the main diagonal equals {result}");