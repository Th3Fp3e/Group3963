//                                 Задача 65
// Задайте значения M и N. Напишите программу, 
// которая найдёт все натуральные элементы в промежутке от M до N.


int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

string RecMN(int m, int n)
{
    string res = string.Empty;
    if (m >= n)
    {
        res = res + n;
    }
    else
    {
        res = res + m + " " + RecMN(m + 1, n);
    }
    return res;
}

void PrintData(string msg)
{
    Console.WriteLine(msg);
}

int m = ReadData("Enter your first number: ");
int n = ReadData("Enetr your second number: ");

if (m < n) string result = RecMN(m, n);
else string result = RecMN(n, m);

PrintData(result);