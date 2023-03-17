// Задача 66: 
// Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

int RecSumMN(int m, int n)
{
    int res = 0;
    if (m >= n)
    {
        res = res + n;
    }
    else
    {
        res = res + m + RecSumMN(m + 1, n);
    }
    return res;
}

void PrintData(string msg)
{
    Console.WriteLine(msg);
}

int m = ReadData("Enter your first number: ");
int n = ReadData("Enetr your second number: ");


if (m < n) 
{
    PrintData($"The sum of numbers from {m} to {n} equals {RecSumMN(m, n)}");
}
else 
{
    PrintData($"The sum of numbers from {n} to {m} equals {RecSumMN(n, m)}");
}