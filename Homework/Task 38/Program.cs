// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.


// We're using "double", because we're working with fractional values
double[] GetArray(int length, int minVal, int maxVal)
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
                                                           // This little addition will create a fraction for our random number
        array[i] = new Random().Next(minVal, maxVal) + (new Random().NextDouble());
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

int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string msg)
{
    Console.WriteLine(msg);
}

// Insert-sorting method...
void InsertSort(double[] arr)
{
    for (int i = 1; i < arr.Length; i++)
    {
        double x = arr[i];
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

// And a method for calculating the difference between set array's min and max values
double MinMaxDiff(double[] arr)
{
    // We'll set the original values to be the first element, so it would work within the array
    double min = arr[0];  
    double max = arr[0];  
    for (int i = 0; i < arr.Length-1; i++) // Calculating max..
    {
        if (arr[i + 1] > arr[i]) max = arr[i + 1];
    }
    for (int j = 0; j < arr.Length-1; j++)  // ... and min values 
    {
        if (arr[j + 1] < arr[j]) min = arr[j + 1];
    }
    return max - min;  // Returning the difference between them
}

int N = ReadData("Enter the desired length: ");
int min = ReadData("Enter the minimum value: ");
int max = ReadData("Enter the maximum value: ");
double[] testArray = GetArray(N, min, max);
Print1DArray(testArray);

// We'll first figure out the difference...
double diff = MinMaxDiff(testArray);
PrintData($"The difference between this array's min and max value equals to {diff}");

// ... and then insert-sort the array
InsertSort(testArray);
Print1DArray(testArray);