// Задача 64: 
// Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от 1 до N. Выполнить с помощью рекурсии.

int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}


string GetNumLine(int n)
{
    if (n == 1)
    {
        return "1";
    }
    else
    {
        return GetNumLine(n - 1) + " " + n;
    }
}

int num = ReadData("Enter your number: ");
string line = GetNumLine(num);
Console.WriteLine(line);