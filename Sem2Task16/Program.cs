// Задача №16
// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.

void IfSquared(int res1, int res2)
{
    if (res2 == res1 * res1)
    {
        Console.WriteLine($"{res2} - квадрат {res1}");
    }
}


Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()?? "0");
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()?? "0");

IfSquared(num1, num2);
IfSquared(num2, num1);
