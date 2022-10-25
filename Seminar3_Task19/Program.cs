/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль. Не использовать String!
 14212 -> нет, 12821 -> да, 23432 -> да.*/

Console.Clear();

Console.Write("Введите число: ");
int input1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число повторно: ");
int input2 = Convert.ToInt32(Console.ReadLine());

CompareArrays(input1, input2);

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


void CompareArrays(int number1, int number2)
{
    int length1 = GetLengthNumber(number1);
    int length2 = GetLengthNumber(number2);
    int[] array1 = new int[length1];
    int[] array2 = new int[length2];
    int count = length1;

    for(int i = 0; i < length1; i++)
    {
        array1[i] = number1 % 10;
        number1 /= 10;
    }
    for (int i = 0; i < length1; i++)
    {
        Console.Write(array1[i]);
        Console.Write(" ");
    }
    Console.WriteLine(" ");
    for(int i = length2 - 1; i >= 0; i--)
    {
        array2[i] = number2 % 10;
        number2 /= 10;
    }
    for (int i = 0; i < length2; i++)
    {
        Console.Write(array2[i]);
        Console.Write(" ");
    }
    int y = 0;
    for(int i = 0; i < count; i++)
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