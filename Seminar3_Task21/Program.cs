/*Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.Clear();

Console.WriteLine("Введите координаты точи х1");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точи y1");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точи z1");
double z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точи х2");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точи y2");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точи z2");
double z2 = Convert.ToInt32(Console.ReadLine());

double final = DistanceBetweenPoints(x1, y1, z1, x2, y2, z2);

Console.Write(final);

double DistanceBetweenPoints(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));

    return result;
}