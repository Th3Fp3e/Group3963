// Задача 50. 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве
// , и возвращает значение этого элемента или же указание, что такого элемента нет.


int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[,] Gen2DArray(int countRows, int countColumn, int max)
{
    int[,] arr = new int[countRows, countColumn];
    for (int i = 0; i < countRows; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr[i, j] = new Random().Next(10, max + 1);
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

bool IsItThere(int[,] arr, int row, int col)
{
    if (row < arr.GetLength(0) && col<arr.GetLength(1)) return true;
    else return false;
}

void Print2DArrayElem(int[,] arr, int row, int col)
{
    Console.WriteLine($"Your element is {arr[row, col]}");
}

int[,] testArr = Gen2DArray (13, 20, 100);
int inRow = ReadData("Enter the row of the element to search: ");
int inCol = ReadData("Enter the column of the element to search: ");

Print2DArr(testArr);

if (IsItThere(testArr, inRow, inCol))
{
    Print2DArrayElem(testArr, inRow, inCol);
}
else Console.WriteLine("There's no such element. Try different index.");