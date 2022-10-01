﻿// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

ulong Prompt(string message) //беззнаковое длинное
{
    Console.Write(message);
    return Convert.ToUInt64(Console.ReadLine());
}

ulong SumNumbers(ulong number)
{
    ulong sum = 0;
    for (ulong i = 1; i <= number; i++)
    {
        sum = sum + i;
    }
    return sum;
}

ulong SumGausNumbers(ulong number)
{
    return (number + 1) * number / 2;
}

ulong num = Prompt("Введите число > ");
ulong result = SumNumbers(num);
System.Console.WriteLine($"Сумма чисел равна {result}");
System.Console.WriteLine($"Сумма чисел по Гауссу равна {SumGausNumbers(num)}");