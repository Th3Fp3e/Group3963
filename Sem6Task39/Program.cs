// Задача №39
// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)

int[] GetArray(int length, int minVal, int maxVal)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
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

void SwapArray(int[] arr)
{
    int bufElem = 0;
    for (int i = 0; i < (arr.Length / 2); i++)
    {
        bufElem = arr[i];
        arr[i] = arr[arr.Length-1  - i];
        arr[arr.Length - i] = bufElem;
    }
}

int[] SwapNewArray(int[] arr)
{
    int[] outArr = new int[arr.Length];
    for (int i = 0; i < outArr.Length; i++)
    {
        outArr[i] = arr[arr.Length -1 - i];
    }
    return outArr;
}

int[] testArray = GetArray(123, 10, 100);
PrintArray(testArray);
// SwapArray(testArray);
int[] newArr = SwapNewArray(testArray);
PrintArray(newArr);