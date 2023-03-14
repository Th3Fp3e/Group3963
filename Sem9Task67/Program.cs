// Задача 67
// примает на вход число и возвращает сумму числа

int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string msg)
{
    Console.WriteLine(msg);
}

int SumDigitRec(int num)
{
    if (num == 0) return 0;
    else return num%10 + SumDigitRec(num/10);
}

Console.Clear();
int inputNum = ReadData("Enter your number: ");
PrintData($"{SumDigitRec(inputNum)}");