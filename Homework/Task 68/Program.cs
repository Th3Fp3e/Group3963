// Задача 68: 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

int RecAckerMN(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else
    {
        if (m != 0 && n == 0)
        {
            return RecAckerMN(m - 1, 1);
        }
        else
        {
            return RecAckerMN(m - 1, RecAckerMN(m, n - 1));
        }
    }
}


void PrintData(string msg)
{
    Console.WriteLine(msg);
}

int m = ReadData("Enter your first number: ");
int n = ReadData("Enetr your second number: ");

PrintData($"The result of Ackermann function for your numbers {m} and {n} equals {RecAckerMN(m, n)}");