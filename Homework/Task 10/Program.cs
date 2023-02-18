// Задача 10
// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число: ");
string? num = Console.ReadLine();

// Переводим введенное число в массив
char[] arr = num.ToCharArray();

if (arr.Length >= 2)
{
    int secondDigit = (int)arr[1] - 48; // Выражение (<> - 48) переводит в int значение char (ASCII)
    Console.WriteLine($"{secondDigit} - вторая цифра числа {num}");
}
