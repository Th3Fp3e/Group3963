// Сделаем функцию для поиска максимума из трех чисел

int Max(int num1, int num2, int num3)
{
    int result = num1;
    if (num2 > result) result = num2;
    if (num3 > result) result = num3;
    return result;
}

Console.Write("Введите первое число: ");
string? lineNum1 = Console.ReadLine();
Console.Write("Введите второе число: ");
string? lineNum2 = Console.ReadLine();
Console.Write("Введите третье число: ");
string? lineNum3 = Console.ReadLine();

if (lineNum1 != null && lineNum2 != null && lineNum3 != null)
{
    int num1 = int.Parse(lineNum1);
    int num2 = int.Parse(lineNum2);
    int num3 = int.Parse(lineNum3);
    int max = Max (num1, num2, num3);
    Console.Write("Максимальное значение - ");
    Console.WriteLine(max);
}

