// Задача 60. ...
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.

int[,,] Gen3DArray(int rows, int col, int depth, int min, int max)
{
    int[,,] arr = new int[rows, col, depth];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            // By simply adding another variable, we can create a 3D array in this method
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i, j, k] = new Random().Next(min, max + 1);
            }
        }
    }
    return arr;
}

void Print3DArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            // We'll split each element with vertical bar...
            Console.Write("|");
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k]} ({i},{j},{k})|");
            }
            // ...and break to the next line after finishing with every depth (or third dimantion of the matrix)
            Console.WriteLine();
        }
    }
}

Console.Clear();
int[,,] testArray = Gen3DArray(2, 2, 2, 10, 99);

Print3DArray(testArray);