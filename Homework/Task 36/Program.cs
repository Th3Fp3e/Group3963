// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] GetArray(int length, int minVal, int maxVal)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(minVal, maxVal + 1);
    }
    return array;
}

void Print1DArray(int[] array)
{
    Console.Write("[");
    for (int j = 0; j < array.Length - 1; j++)
    {
        Console.Write($"{array[j]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]}]");
}

int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string msg)
{
    Console.WriteLine(msg);
}

// A method for calculating teh sum of elements by ODD INDEX
int OddIndexSum(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 1) res += arr[i];
    }
    return res;
}

// And a method for odd ELEMENTS
int OddElementSum(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 1) res += arr[i];
    }
    return res;
}


int N = ReadData("Enter the desired length: ");
int min = ReadData("Enter the minimum value: ");
int max = ReadData("Enter the maximum value: ");
int[] testArray = GetArray(N, min, max);
Print1DArray(testArray);
int result1 = OddIndexSum(testArray);
PrintData($"The sum of odd index elemets equals to {result1}");
int result2 = OddElementSum(testArray);
PrintData($"The sum of odd elemets equals to {result2}");