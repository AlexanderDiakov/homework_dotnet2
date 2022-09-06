Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void Weekday(int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("этот день выходной");
    }
    else
    {
        Console.WriteLine("этот день не выходной");
    }
}

Weekday(dayNumber);