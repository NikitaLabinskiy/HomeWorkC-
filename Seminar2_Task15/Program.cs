Console.Clear();

void Week (int number)
{
    bool flag = false;
    int b = 6;
    int a = 7;
    if (number == a | number == b)
    {
        flag = true;
    }
    else
    {
        flag = false;
    }
    Console.Write(flag);
}

Console.Write("Введите число от 1 до 7: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Week(number1);