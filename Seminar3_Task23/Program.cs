/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. 
Задание должно быть выполнено в методе и метод должен вернуть массив чисел.
3 -> 1, 8, 27; 5 -> 1, 8, 27, 64, 125*/

Console.Clear();

Console.Write("Введите число: ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int N);

PrintArray(TableOfCubes(N));

int[] TableOfCubes(int number)
{
    int[] array = new int[number + 1];
    for(int i = 1; i <= number; i++)
    {
        array[i] = (i * i) * i;
    }
    return array;
}

void PrintArray(int[] array)
{
    for(int i = 1; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}