Console.Clear();

void ShowSecondDigit(int number)
{
    if(number > 100 & number < 1000)
    {
        int lastDigit = number / 10;
        int middleDigit = number / 100;
        int resault = lastDigit - middleDigit * 10;
        Console.Write(resault);
    }
    else
    {
        Console.Write("Ошибка");
    }
}


Console.Write("Введите трехзначное число ");

int RundommNumber = Convert.ToInt32(Console.ReadLine());

ShowSecondDigit(RundommNumber);