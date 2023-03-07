// Задача №55
// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.


int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[,] Gen2DArr(int countRow, int countColumn, int min, int max)
{
    // Корректировка входных данных
    if (min > max)
    {
        int buf = min;
        min = max;
        max = buf;
    }
    Random rnd = new Random();
    int[,] arr = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr[i, j] = rnd.Next(min, max + 1);
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
            Console.Write(arr[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

void Transp2DArr(int [,] arr)
{
    if(arr.GetLength(0) == arr.GetLength(1))
    {
        int temp = 0;
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            for(int j = i + 1; j < arr.GetLength(1); j++)
            {
                temp = arr[i, j];
                arr[i, j] = arr[j, i];
                arr[j, i] = temp;
            }
        }
    }
    else
    {
        Console.WriteLine("Transposition is impossible!");
        Console.WriteLine("Make sure that the number of rows and columns of your matrix is equal!");
    }
}

int inRow = ReadData("Please enter the desired number of rows: ");
int inCol = ReadData("Please enter the desired number of columns: ");
int[,] testArr = Gen2DArr(inRow, inCol, 1, 9);
Print2DArr(testArr);
Console.WriteLine();

Transp2DArr(testArr);
Print2DArr(testArr);