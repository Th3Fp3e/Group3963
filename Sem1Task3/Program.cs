// Задача №5
// Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.

Console.Write("Введите ваше число: ");
string? lineN = Console.ReadLine();

int N = int.Parse(lineN);

string ves = String.Empty;
int negN = N * (-1);

while (negN < N)
{
    ves = ves + negN + ", ";
    negN++;
}
ves = ves + N;
Console.WriteLine(ves);