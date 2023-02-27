// Задача 25: 
// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Nothing unusual about those two
void PrintData(string msg)
{
    Console.WriteLine(msg);
}

int ToPower(int num, int pow)  
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

// int A = ReadData("Enter your number: ");
// int B = ReadData("Enter the power to raise it to: ");

// int result = ToPower(A, B);
// PrintData($"{A}, raised to the power of {B}, equals {result}");

// (*) Написать калькулятор с операциями +, -, /, * и возведение в степень

// Adding a referense list of commands 
string text = "List of commands: "
+ "1) Adding "
+ "2) Subtracting "
+ "3) Dividing "
+ "4) Multiplying "
+ "5) Raise to power";

// Creating a base for our operations
int Add(int num, int add)
{
    int res = num + add;
    return res;
}

int Subtract(int num, int sub)
{
    int res = num - sub;
    return res;
}

int Divide(int num, int div)
{
    int res = num / div;
    return res;
}

int Multiply(int num, int mult)
{
    int res = num * mult;
    return res;
}

int A = ReadData("Enter the first number: ");
int B = ReadData("Enter the second number: ");
Console.WriteLine(text);
int command = ReadData("Enter the desired command (from 1 to 5): ");

int result = 0;
if (command == 1) result = Add(A, B);
if (command == 2) result = Subtract(A, B);
if (command == 3) result = Divide(A, B);
if (command == 4) result = Multiply(A, B);
if (command == 5) result = ToPower(A, B);

PrintData($"The result of entered command is {result}");