// Задача №44
// Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.

//  We won't be using recursion!

int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string msg)
{
    Console.WriteLine(msg);
}

string FiboNum(int num)
{
    string res = "0, 1, ";
    int first = 0;
    int last = 1;
    for (int i = 2; i < num; i++)
    {
        res = res + (first + last).ToString()+", ";
        (first, last) = (last, first+last);
    }
    return res;
}

int N = ReadData("Enter the length of desired Fibonacci sequense: ");
string result = FiboNum(N);
PrintData(result);