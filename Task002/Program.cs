Console.Clear();

void NewArray(int numberA, int numberB)
{
    // Console.Write("Введите два числа: ");
    // numberA = Convert.ToInt32(Console.ReadLine());
    // numberB = Convert.ToInt32(Console.ReadLine());
    if (numberA > numberB)
    {
        Console.Write("max = ");
        Console.Write(numberA);
    }
    else
    {
        Console.Write("max = ");
        Console.Write(numberB);
    }
}

NewArray(4, 8);