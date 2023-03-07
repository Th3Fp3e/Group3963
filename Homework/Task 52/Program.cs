// Задача 52. 
// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[,] Gen2DArray (int rows, int col,int min, int max)
{
    int[,] arr = new int[rows, col];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(min, max+1);
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

// With this method we'll calculate the mean number for each column
double CalcColMean(int[,] arr, int col)
{
    double sum = 0;
    int count = 0;
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        // There's no need to change columns, since we're calculating one column per method
        sum += arr[i, col];
        count++;
    }
    return sum/count;
}

int inRow = ReadData("Please enter the desired number of rows: ");
int inCol = ReadData("Please enter the desired number of columns: ");
int[,] testArr = Gen2DArray(inRow, inCol, 10, 100);
Print2DArr(testArr);
Console.WriteLine();

// Simce our method only calculates one result per column, we'll make a cycle that goes through all columns in the matrix
for (int j = 0; j < testArr.GetLength(1); j++)
{
    double res = CalcColMean(testArr, j);
    Console.WriteLine($"The mean number of column {j} equals {res}");
}