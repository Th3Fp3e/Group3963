// 

//Метод читает данные от пользователя
int ReadData (string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

//Метод выводит данные пользователя
void PrintData (string msg, double val)
{
    Console.WriteLine(msg+val);
}

//Метод находщит расстояние между точками на плоскости
double CalcLen (int x1, int x2, int y1, int y2)
{
    return Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
}

int x1 = ReadData("Введите координату точки х точки А: ");
int y1 = ReadData("Введите координату точки у точки А: ");
int x2 = ReadData("Введите координату точки х точки В: ");
int y2 = ReadData("Введите координату точки у точки В: ");

double res = CalcLen(x1, x2, y1, y2);

PrintData("Расстояние между точками А и В: ", res);