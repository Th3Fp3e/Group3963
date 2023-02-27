// Задача 29: 
// Напишите программу, которая задаёт массив из N элементов и выводит их на экран. 
// Ввести с клавиатуры длину массива и диапазон значений элементов.

int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Creating a method for generating an array of specified length with random values from min to max
int[] FillArray(int length, int minVal, int maxVal)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(minVal, maxVal + 1);
    }
    return array;
}

//Now creating a method for printing that array properly, stand by...
void PrintArray(int[] array)
{
    Console.Write("[");  // We'll start with the first border...
    for (int j = 0; j < array.Length - 1; j++)
    {
        Console.Write($"{array[j]}, ");  // ...then all the elements up to the very last...
    }
    Console.WriteLine($"{array[array.Length - 1]}]");  // ...and end with the last element and another border!
}

int N = ReadData("Enter desired array length: ");
int min = ReadData("Enter the minimal value: ");
int max = ReadData("Enter the maximum value: ");

int[] genArray = FillArray(N, min, max);
PrintArray(genArray);