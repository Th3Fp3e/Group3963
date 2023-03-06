// Задача 43: 
// Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

int xCoord = 0;
int yCoord = 1;

int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string msg)
{
    Console.WriteLine(msg);
}

double[] LineData(int lineNum)
{
    double[] lineData = new double[2];
    lineData[0] = ReadData($"Enter the coefficient for {lineNum} line: ");
    lineData[1] = ReadData($"Enter the constant for {lineNum} line: ");
    return lineData;
}

double[] FindLineCoordinates(double[] lineData1, double[] lineData2)
{
    double[] coordinates = new double[2];
    coordinates[xCoord] = (lineData1[1]-lineData2[1]) / (lineData2[0] - lineData1[0]);
    coordinates[yCoord] = lineData1[1] * coordinates[xCoord] + lineData1[1];
    return coordinates;
}

bool IfLinesCross(double[] lineData1, double[] lineData2)
{
    if (lineData1[0] == lineData2[0])
    {
        if (lineData1[1] == lineData2[1]) return false;
    }
    return true;
}

void Print1DArray(double[] array)
{
    Console.Write("(");
    for (int j = 0; j < array.Length - 1; j++)
    {
        Console.Write($"{array[j]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]})");
}

double[] inputLineData1 = LineData(1);
double[] inputLineData2 = LineData(2);

if (!IfLinesCross(inputLineData1, inputLineData2))
{
    PrintData("The lines don't cross or match each other");
}
else
{
    double[] coords = FindLineCoordinates(inputLineData1, inputLineData2); 
    PrintData($"The lines cross at the coordinates: ");
    Print1DArray(coords);
}


