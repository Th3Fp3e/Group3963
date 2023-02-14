// Задача №14
// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine() ?? "0");

if (num % 7 == 0 && num % 23 == 0)
{
    Console.WriteLine($"Число {num} кратно и 7, и 23!");
}
else
{
    if (num % 7 != 0 && num % 23 != 0)
    {
        Console.WriteLine($"Число {num} не кратно ни 7, ни 23");
    }
    else
    {
        if (num % 7 != 0)
        {
            Console.WriteLine($"Число {num} не кратно 7");
        }
        if (num % 23 != 0)
        {
            Console.WriteLine($"Число {num} не кратно 23");
        }
    }
}