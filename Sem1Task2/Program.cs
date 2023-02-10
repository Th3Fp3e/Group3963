// Программа, которая будет выдавать название дня недели по заданному номеру

Console.WriteLine("Введите номер дня: ");
string? lineDay = Console.ReadLine();

if (lineDay != null)
{
    int day = int.Parse(lineDay);
    string[] dayWeek = new string[7];
    dayWeek[0] = "Сегодня понедельник";
    dayWeek[1] = "Сегодня вторник";
    dayWeek[2] = "Сегодня среда";
    dayWeek[3] = "Сегодня четверг";
    dayWeek[4] = "Сегодня пятница";
    dayWeek[5] = "Сегодня суббота";
    dayWeek[6] = "Сегодня воскресенье";

    Console.WriteLine(dayWeek[day - 1]);


    // Задача одной строкой:

    // string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-Ru").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(day));
    // Console.WriteLine(outDayOfWeek);
}
