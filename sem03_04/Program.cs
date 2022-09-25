// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int Prompt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

bool ValidateNumber(int inputNum) //Валидация данных
{
    if (inputNum > 0)
    {
        return true;
    }
    Console.WriteLine("ваше число меньше 1");
    return false;
}

void Square(int number)
{
    int index = 1;
    while (index <= number)
    {
        Console.Write($"{index * index},");
        index++;
    }
}

int number = Prompt("Введите число > ");

if (ValidateNumber(number))
{
    Console.WriteLine();
    Console.Write($"{number} -> ");
Square(number);
}
