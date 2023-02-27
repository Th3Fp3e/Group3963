// Задача 25: 
// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

int ReadData(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()??"0");
}
                                    // Nothing unusual about those two
void PrintData(string msg) 
{
    Console.WriteLine(msg);
}

double ToPower (int num, int pow)  // Using "double" instead of "int" to allow the displeay of higher results
{
    int res = 1;
    if (pow == 0) return res;  // Beacause any number in power 0 equals 1! Math!!! 
    else 
    {
        for (int i = 1; i <= pow; i++)  // Goisng with a simple cycle of multiplying by a set number
        {
            res = res * num;
        }
    }
    return res;
}

int A = ReadData("Enter your number: ");
int B = ReadData("Enter the power to raise it to: ");


double result = ToPower(A, B);
PrintData($"{A}, raised to the power of {B}, equals {result}");