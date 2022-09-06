Console.Write("Введи трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

void SecondDigit(int number)
{
    if (number > 99 && number < 1000)
    {
        Console.WriteLine((number % 100) / 10);
    }
    else
    {
        Console.WriteLine("false");
    }

}
SecondDigit(number);