// Задача 50. 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве
// , и возвращает значение этого элемента или же указание, что такого элемента нет.


int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

// That's a generic array generator

// int[,] Gen2DArray(int countRows, int countColumn, int max)
// {
//     int[,] arr = new int[countRows, countColumn];
//     for (int i = 0; i < countRows; i++)
//     {
//         for (int j = 0; j < countColumn; j++)
//         {
//             arr[i, j] = new Random().Next(10, max + 1);
//         }
//     }
//     return arr;
// }

long FiboNum(int n)
{
    long res = 1;
    if (n ==1 || n ==2) return res;
    long prev = 1;
    long curr = 1;
    for (int i = 2; i <= n; i++)
    {
        res = curr+prev;
        prev = curr;
        curr = res;
    }
    return res;
}

long[,] Gen2DFiboArray(int rows, int col)
{
    long[,] arr = new long[rows, col];
    int count =1;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = FiboNum(count);
            count++;
        }
    }
    return arr;
}

void Print2DArr(long[,] arr)
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

bool IsItThere(long[,] arr, int row, int col)
{
    if (row-1 < arr.GetLength(0) && col-1<arr.GetLength(1)) return true;
    else return false;
}

void Print2DArrayElem(long[,] arr, int row, int col)
{
    Console.WriteLine($"Your element is {arr[row-1, col-1]}");
}

long[,] testArr = Gen2DFiboArray (6, 8);
int inRow = ReadData("Enter the row of the element to search: ");
int inCol = ReadData("Enter the column of the element to search: ");

Print2DArr(testArr);

if (IsItThere(testArr, inRow, inCol))
{
    Print2DArrayElem(testArr, inRow, inCol);
}
else Console.WriteLine("There's no such element. Try different index.");