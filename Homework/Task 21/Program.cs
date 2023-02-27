// Задача 21
 
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
 
int ReadData (string msg) 
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}
 
void PrintData (string msg, double val)
{
    Console.WriteLine(msg+val);
}
 
// This method will allow us to find distance between the points in 3D 
double CalcDist (int x1, int x2, int y1, int y2, int z1, int z2)
{
    return Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)+(z1-z2));
}
 
int x1 = ReadData("Enter the x-coordinate of point A: ");  // 
int y1 = ReadData("Enter the y-coordinate of point A: ");  //
int z1 = ReadData("Enter the z-coordinate of point A: ");  //  Setting up the coordinates
int x2 = ReadData("Enter the x-coordinate of point B: ");  //     for both points
int y2 = ReadData("Enter the y-coordinate of point B: ");  //
int z2 = ReadData("Enter the z-coordinate of point B: ");  //
 
double res = CalcDist(x1, x2, y1, y2, z1, z2); // Getting the distance in 3D space
 
PrintData("The distance between points A and B in 3D environment: ", res);