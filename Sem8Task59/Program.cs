// Задача №59
// Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.

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
            Console.Write(arr[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

int[,] Update2DArr(int[,] arr, int row, int col)
{
    int[,] res = new int[arr.GetLength(0)-1, arr.GetLength(1)-1];
    int k = 0;
    int m = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i != row && j != col)
            {
                res[k,m] = arr[i, j];
                m++;
            }
        }
        
    }
    return res;
}

int SearchMinElem(int[,] arr)
{
    int min = arr[0, 0];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < min)
            {
                min = arr[i, j];
            }
        }
    }
    return min;
}

int SearchMinElemRow(int[,] arr)
{
    int min = arr[0, 0];
    int minRow = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < min)
            {
                min = arr[i, j];
                minRow = i;
            }
        }
    }
    return minRow;
}

int SearchMinElemCol(int[,] arr)
{
    int min = arr[0, 0];
    int minCol = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < min)
            {
                min = arr[i, j];
                minCol = j;
            }
        }
    }
    return minCol;
}

int inRow = ReadData("Please enter the desired number of rows: ");
int inCol = ReadData("Please enter the desired number of columns: ");
int[,] testArr = Gen2DArray(inRow, inCol, 10, 100);
Print2DArr(testArr);
Console.WriteLine();

Console.WriteLine($"The minimal element of the matrix is {SearchMinElem(testArr)}");
int[,] updArr = Update2DArr(testArr, 1,4);
Print2DArr(updArr);
