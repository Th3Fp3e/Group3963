// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

double[] GetArray(int length, int minVal, int maxVal)
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(minVal, maxVal + 1)+(new Random().NextDouble());
        array[i] = Math.Round(array[i], 3);
    }
    return array;
}

void Print1DArray(double[] array)
{
    Console.Write("[");  
    for (int j = 0; j < array.Length - 1; j++)
    {
        Console.Write($"{array[j]}, "); 
    }
    Console.WriteLine($"{array[array.Length - 1]}]");  
}

void BubbleSort(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length -1 - i; j++)
        {
            if (array[j] > array[j+1])
            {
                double buf = array[j];
                array[j] = array[j+1];
                array[j+1] = buf;
            }
        }
    }
}

double[] testArray = GetArray(25, 1, 25);
Print1DArray(testArray);
BubbleSort(testArray);
Print1DArray(testArray);