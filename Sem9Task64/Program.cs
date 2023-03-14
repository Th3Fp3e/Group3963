// Задача 64
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в 
// промежутке от N до 1. Выполнить с помощью рекурсии.


int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

void GenLineRec(int n)
{
    Console.Write(n + " ");
    if (n == 1)
    {

    }
    else
    {
        GenLineRec(n - 1);
    }
}

int num = ReadData("Enter your number: ");
GenLineRec(num);