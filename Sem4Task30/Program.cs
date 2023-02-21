// Задача №30
// Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.

void Print1DArray(int[] array)
{
    Console.Write("["); // We open the print with a square bracket
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", "); // We print all members until the last with a stops
    }
    Console.WriteLine(array[array.Length - 1] + "]"); // We end the print with the last member and a closing square bracket
}

int[] Gen1DArray(int len, int min, int max)
{
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

int ReadData(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()??"0");
}

int length = ReadData("Enter the desired length: ");
int minimum = ReadData("Enter the minimum value: ");
int maximum = ReadData("Enter the maximum value: ");

int[] arr = Gen1DArray(length, minimum, maximum);
Print1DArray(arr);
