// Напишите программу, которая будет принимать на вход пять чисел и
// выводить сумму и среднее арифметическое этих чисел.
// 2, 5, 6, 8, 1 -> сумма 22, среднее 4,4

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}

int[] numbers = new int[5]; //объявляем новый массив
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = Prompt($"Введите число {i + 1}: ");
}

int summ = Summ(numbers);
double average;

int Summ(int[] numbers)
{
    int summ = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        summ += numbers[i];
    }
    return summ;
}
    average = summ / numbers.Length;
    int reminds = summ % numbers.Length;
    System.Console.WriteLine(summ);
    System.Console.Write($"{average},{reminds}");