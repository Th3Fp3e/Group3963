// Задача 15: 
// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число от 1 до 7: ");
int weekDay = int.Parse(Console.ReadLine()??"0");


// Создадим функцию выявления выходного дня
bool IsItWeekend(int num)
{
    if (num > 5)
    {
        return true;
    }
    return false;
}

if (weekDay > 0 && weekDay <= 7) // Проверяемб подпадает ли число под дни недели
{
    if (IsItWeekend(weekDay))
    {
        Console.WriteLine("Сегодня выходной!");
    }
    else
    {
        Console.WriteLine("Боюсь, сегодня будний день");
    }
}
else
{
    Console.WriteLine("Повторюсь, от 1 до 7!"); // Шутка для тех, кто ввел число неправильно
}

