// Задача №7
// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает последнюю цифру этого числа.

Console.Write("Введите трехзначное число: ");
string? lineN = Console.ReadLine();

int N = int.Parse(lineN);
if (N > 99 && N < 1000)
{
    int lastN = N%10;
    Console.WriteLine("Последняя цифра вашего числа: "+lastN);
}
else
{
    Console.WriteLine("Введите трехзначное число!");
}