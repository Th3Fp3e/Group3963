// Задача №22
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.

string LineBuilder(int num, int pow)
{
    string res = string.Empty;
    for (int i = 1; i <= num; i++)
    {
        res = res + Math.Pow(i, pow) + " ";
    }
    return res;
}

Console.WriteLine("Введите конечное число ");
int n = int.Parse(Console.ReadLine()??"0");

Console.WriteLine(LineBuilder(n, 1));
Console.WriteLine(LineBuilder(n, 2));