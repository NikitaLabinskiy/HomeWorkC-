Console.Clear();

Console.Write("Введите число: ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int N);

TableOfCubes(N);

void TableOfCubes(int number)
{
    int[] array = new int[number + 1];
    for(int i = 1; i <= number; i++)
    {
        array[i] = (i * i) * i;
        Console.Write($"{array[i]} ");
    }
}