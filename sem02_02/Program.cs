// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

int randValue = new Random().Next(10, 100); // выводим случайное значение
Console.WriteLine(randValue);

int firstNumber = randValue / 10;
int secondNumber = randValue % 10;
int maxNumber = firstNumber;

if (maxNumber < secondNumber)
{
    maxNumber = secondNumber;
}

    Console.WriteLine(maxNumber);