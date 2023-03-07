// Задача 47. 
// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

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
    // We're using the specific command to create a pool of colors to paint the printed symbols
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new Random().Next(0,16)]; // This will allow the programm to chose from set colors randomly
            Console.Write(arr[i, j] + " ");
            Console.ResetColor(); // And this will reset the color scheme after each print
        }
        Console.WriteLine();
    }
}

int inputRows = ReadData("Enter the desired amount of rows: ");
int inputColumns = ReadData("Enter the desired amount of columns: ");

int[,] testArr = Gen2DArray(inputRows, inputColumns, 100);
Print2DArr(testArr);