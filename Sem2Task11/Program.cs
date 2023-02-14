// Задача №12
// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. 
// Если второе число некратно первому, то программа выводит остаток от деления.

Console.Write("Введите первое число: ");
int firstNum = int.Parse(Console.ReadLine()??"0");
Console.Write("Введите второе число: ");
int secondNum = int.Parse(Console.ReadLine()??"0");

if (firstNum % secondNum == 0)
{
    Console.WriteLine(secondNum + " кратно " + firstNum);

}
else
{
    Console.WriteLine("Остаток от деления = " + (firstNum % secondNum));
}

// Либо:
// int rem = firstNum % secondNum;
// if (rem == 0)
// {
//     Console.WriteLine("Кратно!");
// }
// else
// {
//     Console.WriteLine(rem);
// }