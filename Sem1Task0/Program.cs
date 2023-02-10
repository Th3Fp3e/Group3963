// Задача 1
// Написать программу, которая принамает число и выдает его квадрат

// Считываем данных с консоли
Console.Write("Введите число: ");
string? inputNum = Console.ReadLine();

// Проверяем, чтобы данные не были пустыми
if (inputNum != null)
{
    // Парсим введенное число
    int number = int.Parse(inputNum);

    // Находим квадрат числа
    int outNum = (int)Math.Pow(number, 2);

    // Выводим квадрат числа
    Console.Write("Квадрат вашего числа - ");
    Console.WriteLine(+outNum);
}

// Весь код в одну строчку:
// Console.WriteLine((int)Math.Pow(int.Parse(inputNum), 2));