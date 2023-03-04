// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[] ReadMessage(int length)
{
    int[] message = new int[length];
    for (int i = 0; i < message.Length; i++)
    {
        message[i] = ReadData($"Please input the {i+1} element: ");
    }
    return message;
}

int CountThePositives(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

void PrintData(string msg)
{
    Console.WriteLine(msg);
}


int length = ReadData("Enther the desired length: ");
int[] inputLine = ReadMessage(length);
int result = CountThePositives(inputLine);
PrintData($"The amount of positive numbers you have enetered is {result}");