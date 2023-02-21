// Задача №26
// Напишите программу, которая принимает на вход число 
// и выдаёт количество цифр в числе.

int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintResult(string message)
{
    Console.WriteLine(message);
}

int DigitsCount(int number)
{
    int digits = 0;

    while (number > 0)
    {
        digits += 1;
        number = number / 10;
    }
    return digits;
}

int num = ReadData("Enter your value: ");
PrintResult("The number of digits equals " + DigitsCount(num));