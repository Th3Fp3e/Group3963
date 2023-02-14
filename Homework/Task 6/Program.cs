Console.Write("Введите число для проверки: ");
string? lineNum = Console.ReadLine();

if (lineNum != null)
{
    int num = int.Parse(lineNum);
    if (num % 2 == 0)
    {
        Console.WriteLine("Ваше число четное!");
    }
    else
    {
        Console.WriteLine("Ваше число нечетное!");
    }
}