//#69 
// Напишите прграмму, которая будет принимать 2 числа А и В
// возведите А в степень В с помощью рекурсии

int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string msg)
{
    Console.WriteLine(msg);
}

long RaiseToRec(int a, int b)
{
    if (b == 0) return 1;
    else
    {
        if (b % 2 == 0) return a * a * RaiseToRec(a, b - 2);
        else return a * RaiseToRec(a, b - 1);
    }
}

long MyPowRec(int a, int b)
{
    if (b == 2)
    {
        return a*a;
    }
    else
    {
        return MyPowRec(a,b/2)*MyPowRec(a,b/2);
    }
}


Console.Clear();
int num = ReadData("Enter your number: ");
int deg = ReadData("Enter the degree to raise to: ");

DateTime d1 = DateTime.Now;
PrintData($"{RaiseToRec(num, deg)}");
Console.WriteLine("RaiseTo result: " + (DateTime.Now-d1));

DateTime d2 = DateTime.Now;
PrintData($"{MyPowRec(num, deg)}");
Console.WriteLine("MyPow result: " + (DateTime.Now-d2));