// Задача 13: 
// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

Console.WriteLine("Введите ваше число: ");
string? num = Console.ReadLine();

char[] arr = num.ToCharArray();

if (arr.Length > 2)
{
    int thirdDigit = (int)arr[2] - 48;
    Console.WriteLine($"{thirdDigit} - третья цифра числа {num}");
}
else
{
    Console.WriteLine($"В числе {num} нет третьей цифры");
}