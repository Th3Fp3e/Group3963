// Задача №45
// Напишите программу, которая будет создавать копию заданного одномерного массива 
// с помощью поэлементного копирования.

int[] GetArray(int length, int minVal, int maxVal)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(minVal, maxVal + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");  
    for (int j = 0; j < array.Length - 1; j++)
    {
        Console.Write($"{array[j]}, "); 
    }
    Console.WriteLine($"{array[array.Length - 1]}]");  
}

object[] CopyArray(params object[] inputArr)
{
    object[] outArr = new int[inputArr.Length];
    
}