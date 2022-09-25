// Напишите программу, которая генерирует последовательность случайных чисел из 10 элементов в диапазоне от 1 до 10, и подсчитывает, сколько сгенерировалось чисел больше 5.
int size = 10;

void Print(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]:f2} \t"); // \t - догонит до 8 символов
    }
    Console.WriteLine();
}

double[] GenerateArray(int size)
{
    double[] numbers = new double[size];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1, 10) + new Random().NextDouble(); //
    }
    return numbers;
}
int Count(double[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 5)
        {
            count++;
        }
    }
    return count;
}

double[] numbers = GenerateArray(size);

Print(numbers);
System.Console.WriteLine(Count(numbers));