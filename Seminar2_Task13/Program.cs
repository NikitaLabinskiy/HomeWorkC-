Console.Clear();

int number = 37;

if (number > 999 | number < 100 )
{
    while(number > 999 | number < 100 )
    {
        if(number > 999)
        {
            number /= 10;
        }
        if(number < 100)
        {
            Console.Write("Третьей цифры нет!");
            break;
        }
        if (number < 999 & number >= 100)
        {
            Console.Write(number % 10);
        }
    }
}
else
{
    Console.Write(number % 10);
}