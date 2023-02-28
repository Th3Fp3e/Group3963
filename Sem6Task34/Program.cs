// Create a programm that generates a 1D array of random values 
// and calculates the number of even values

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

int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string msg)
{
    Console.WriteLine(msg);
}

int VarNaive(int[] inputArray)
{
    int result = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i] % 2 == 0) result ++;
    }
    return result;
}

int N = ReadData("Enter the desired length: ");
int min = ReadData("Enter the minimum value: ");
int max = ReadData("Enter the maximum value: ");
int[] testArray = GetArray(N, min, max);
PrintArray(testArray);
int result = VarNaive(testArray);
PrintData(result.ToString());