/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль. Не использовать String!
 14212 -> нет, 12821 -> да, 23432 -> да.*/

Console.Clear();

Console.Write("Введите число: ");
int input1 = Convert.ToInt32(Console.ReadLine());

Polindrom(input1);

int GetLengthNumber(int number)
{
    int count = 0;
    while(number > 0)
    {
        number /= 10;
        count++;
    }
    return count;
}

int[] ConvertToArray(int number)
{
    int length = GetLengthNumber(number);
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = number % 10;
        number /= 10;
    }
    for (int i = 0; i < length; i++)
    {
        Console.Write(array[i]);
        Console.Write(" ");
    }
    return array;
}

int[] ReverceArray(int number)
{
    int length = GetLengthNumber(number);
    int[] array = new int[length];
    for(int i = length - 1; i >= 0; i--)
    {
        array[i] = number % 10;
        number /= 10;
    }
    for (int i = 0; i < length; i++)
    {
        Console.Write(array[i]);
        Console.Write(" ");
    }
    return array;
}

void CompareArrays(int[] array1, int[] array2)
{
    int y = 0;
    for(int i = 0; i < array1.Length; i++)
    {
        if(array1[i] == array2[i])
        {
            y++;
            continue;
        }
        else
        {
            Console.WriteLine("");
            Console.Write("Число не является полиндромом");
            break;
        }
    }
    if (array1.Length == y)
    {
        Console.WriteLine("");
        Console.WriteLine("Число является полиндромом");
    }
}

void Polindrom(int number1)
{
    // int length1 = GetLengthNumber(number1);
    int number2 = number1;
    int[] array1 = ConvertToArray(number1);
    Console.WriteLine("");
    int[] array2 = ReverceArray(number2);
    // int count = length1;
    CompareArrays(array1, array2);
}
