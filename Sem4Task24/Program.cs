// Задача №24
// Напишите программу, которая принимает на вход число (А) 
// и выдаёт сумму чисел от 1 до А.

int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintResult(string message)
{
    Console.WriteLine(message);
}

int SumSimple(int numA)
{
    int sum = 0;

    for (int i = 0; i <= numA; i++)
    {
        sum = sum + i;
    }
    return sum;
}

long SumGauss(int numA)
{
    // int sum = 0;
    // sum = ((1+numA)*numA) / 2;
    // return sum;
    return ((1 + (long)numA) * (long)numA) / 2;
}

int numberA = ReadData("Введите число А: ");

DateTime d1 = DateTime.Now;
int res1 = SumSimple(numberA);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
long res2 = SumGauss(numberA);
Console.WriteLine(DateTime.Now - d2);

PrintResult($"Сумма чисел от 1 до {numberA} равна(простой способ) " + res1);
PrintResult($"Сумма чисел от 1 до {numberA} равна(способ Гаусса) " + res2);