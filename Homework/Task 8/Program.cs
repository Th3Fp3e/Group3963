void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = index + 1;
        index++;
    }
}

void PrintEvenArray(int[] col)
{
    int count = col.Length;
    int position = 3;
    if (count > 1) Console.Write("2");
    while (position < count)
    {
        if (col[position] % 2 == 0)
        {
            Console.Write(", " + col[position]);
        }
        position++;
    }
}

// Либо:
// void PrintEvenArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count) 
//     {
//         if (col[position] % 2 == 0) 
//         {
//             Console.Write(col[position]);
//             position
//             break;
//         }
//         position++;
//     }
//     while (position < count)
//     {
//         if (col[position] % 2 == 0)
//         {
//             Console.Write(", " + col[position]);
//         }
//         position++;
//     }
// }

Console.Write("Введите число N: ");
string? lineN = Console.ReadLine();

if (lineN != null)
{
    int N = int.Parse(lineN);
    int[] array = new int[N];
    FillArray(array);
    PrintEvenArray(array);
}

