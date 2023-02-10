// Задача 2: 
// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
string? lineNum1 = Console.ReadLine();
Console.Write("Введите второе число: ");
string? lineNum2 = Console.ReadLine();

int num1 = int.Parse(lineNum1);
int num2 = int.Parse(lineNum2);

if (num1 > num2)
{
    Console.WriteLine("Первое число больше!");
}
else
{
    Console.WriteLine("Второе число больше!");
}