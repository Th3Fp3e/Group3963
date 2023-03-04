// Задача 43: 
// Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениям

int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string msg)
{
    Console.WriteLine(msg);
}

