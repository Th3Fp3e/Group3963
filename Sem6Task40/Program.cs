// Задача №40
// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.

int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string msg)
{
    Console.WriteLine(msg);
}

// bool TriangleTest(int a, int b, int c)
// {
//     bool result = false;
//     if (FitTest(a, b, c) && FitTest(b, a, c) && FitTest(c, a, b)) result = true;
//     return result;
// }

// bool FitTest(int a, int b, int c)
// {
//     return a <= b + c;  //  With connection to the "bool" method, it only checks the logic of this statement
// }

bool IsTrianglePossible(int A, int B, int C)
{
    return ((A<=B+C)&&(B<=A+C)&&(C<=A+B));
}

int valA = ReadData("Enter the first side length: ");
int valB = ReadData("Enter the second side length: ");
int valC = ReadData("Enter the third side length: ");

if (IsTrianglePossible(valA, valB, valC)) PrintData($"The triangle with sides {valA}, {valB} and {valC} could exist!");
else PrintData($"The triangle with sides {valA}, {valB} and {valC} is impossible");