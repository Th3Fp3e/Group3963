// Задача 27: 
// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

// Starting with the good ond one-two combo
int ReadData(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string msg)
{
    Console.WriteLine(msg);
}

// Making a method for summing the digits...
int SumOfDigits (int num)
{
    int res = 0; // ...by starting at zero...
    while (num >0)
    {
        res += num % 10; // ...then adding the last digit (as %10 leaves exactly the last digit)...
        num = num / 10; // ...and ending with shortening the OG number by 10 before continuing the cycle!
    }
    return res;
}

int input = ReadData("Enter yor value: ");
// Shortening the code a bit here by putting the calculations directly into the output
PrintData($"The sum of digits of your value {input} equals to {SumOfDigits(input)}");