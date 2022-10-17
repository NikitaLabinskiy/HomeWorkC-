Console.Clear();

Console.WriteLine("Введите число");

int RundommNumber = Convert.ToInt32(Console.ReadLine());
 
int allEvenNumbers = 2;  //Начал с 2 чтобы сократить программу.

while (allEvenNumbers <= RundommNumber)
{
    Console.Write(allEvenNumbers);
    Console.Write(", ");
    
    allEvenNumbers+=2;
}