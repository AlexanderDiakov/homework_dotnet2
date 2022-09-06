Console.Write("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(number);

void ThirdDigit(string stringNumber)
{
    if (stringNumber.Length > 2)
    {
        Console.WriteLine("Третья цифра --> " + stringNumber[2]);
    }
    else
    {
        Console.WriteLine("третьей цифры нет ");
    }
}
ThirdDigit(stringNumber);
