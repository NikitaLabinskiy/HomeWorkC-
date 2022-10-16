Console.Clear();

void NewArray(int[] numbers)
{
    int length = numbers.Length;
    int index = 0;
    int max = 0;
    while (index < length)
    {
        if (numbers[index] > max)
        {
            max = numbers[index];
        }
        index++;
    }
    Console.Write("Max = ");
    Console.Write(max);
}

int[] numbers = {1992, 372, 5699};

NewArray(numbers);