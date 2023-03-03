// Задача 34: 
//Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.


// Starting with two methods to generate and print a random array

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


// An easy method to calculate an amount of even values in an array

int VarNaive(int[] inputArray)
{
    int result = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i] % 2 == 0) result++;
    }
    return result;
}

// Crerating a bubble sorting method...

void BubbleSort(int[] arr)
{
    int temp = 0;
    for (int j = 0; j < arr.Length; j++) // This will sort through the array multiple times to prevent errors
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i + 1])
            {
                temp = arr[i];       //
                arr[i] = arr[i + 1];   // A simple bubble sort with a temp variable
                arr[i + 1] = temp;     //
            }
        }
    }
}

// ... and an insertion sorting method

void InsertSort(int[] arr)
{
    for (int i = 1; i < arr.Length; i++)
    {
        int x = arr[i];
        int j = i;
        while (j > 0 && arr[j - 1] > x)
        {
            arr[j] = arr[j - 1];
            arr[j - 1] = x;
            j = j - 1;
        }
        arr[j] = x;
    }
}

int N = ReadData("Enter the desired length: ");
int min = ReadData("Enter the minimum value: ");
int max = ReadData("Enter the maximum value: ");
int[] testArray = GetArray(N, min, max);
Print1DArray(testArray);
int result = VarNaive(testArray);
PrintData(result.ToString());


// We'll make a bubble sort and check, how much time it takes

DateTime t1 = DateTime.Now;
BubbleSort(testArray);
Print1DArray(testArray);
Console.WriteLine(DateTime.Now - t1);

// And we'll do the same with Insert-sorting

DateTime t2 = DateTime.Now;
InsertSort(testArray);
Print1DArray(testArray);
Console.WriteLine(DateTime.Now - t2);