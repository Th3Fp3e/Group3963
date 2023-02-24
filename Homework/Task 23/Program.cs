// Задача 23

// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// Creating a method to construct a line of all values from 1 to entered in set power
string PowBuilder(int num, int pow)
{
    string res = string.Empty;
    for (int i = 1; i <= num; i++)
    {
        res = res + Math.Pow(i, pow) + " ";
    }
    return res;
}

int ReadData(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()??"0");
}

int n = ReadData("Enter your value: ");

Console.WriteLine(PowBuilder(n, 1));
Console.WriteLine(PowBuilder(n, 3));