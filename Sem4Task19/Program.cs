int ReadData (string msg)
{
    Console.WriteLine("Введите пятизначное число: ");
    return int.Parse(Console.ReadLine()??"0");
}

