// Задача 62. 
// Напишите программу, которая заполнит спирально массив 4 на 4.


int[,] GetSpire(int n)
{
    // This will be looong and meticulous...
    int[,] result = new int[n, n];
    int count = 1;
    // We'll fill each new turn of the spiral almost manually...
    for (int i = 0; i < n; i++)
    {
        result[0, i] = count;
        count++;
    }
    for (int i = 1; i < n; i++)
    {
        result[i, 3] = count;
        count++;
    }
    for (int i = 2; i >= 0; i--)
    {
        result[3, i] = count;
        count++;
    }
    for (int i = 2; i >= 1; i--)
    {
        result[i, 0] = count;
        count++;
    }
    for (int i = 1; i < n - 1; i++)
    {
        result[1, i] = count;
        count++;
    }
    for (int i = 2; i < n-1; i++)
    {
        result[2,i] = count;
        count++;
    }
    // And then finish with the last remaining element. We can be sure about it, since we only need to fill 4x4 matrix
    result[2,1] = count;
    return result;
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

int[,] testArr = GetSpire(4); // See? Four.
Print2DArr(testArr);