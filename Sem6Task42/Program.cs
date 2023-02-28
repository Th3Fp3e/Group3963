// Задача №42
// Напишите программу, которая будет 
// преобразовывать десятичное число в двоичное.

int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string msg)
{
    Console.WriteLine(msg);
}

string ToBinary(int input)
{
    string res = string.Empty;
    while (input > 0)
    {
        res = input%2 + res;
        input = input/2;
    }
    return res;
}

string DecToBaseNativ (int num, int base1)  
{
    return Convert.ToString(num, base1);  // The Convert.ToString() supports the base system
}

int num = ReadData("Enter a decimal value: ");
string result1 = ToBinary(num);
string result2 = DecToBaseNativ(num, 8);
string result3 = DecToBaseNativ(num, 16);
PrintData($"The binary equivalent of number {num} is {result1}");
PrintData($"The octal equivalent of number {num} is {result2}");
PrintData($"The hexadeciaml equivalent of number {num} is {result3}");