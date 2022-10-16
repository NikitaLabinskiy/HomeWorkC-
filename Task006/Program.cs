Console.Clear();

Console.WriteLine("Введите число");

int RundommNumber = Convert.ToInt32(Console.ReadLine());
if (RundommNumber % 2 == 0)
{
    Console.Write("Четное");
}
else
{
    Console.Write("Нечетное");
}