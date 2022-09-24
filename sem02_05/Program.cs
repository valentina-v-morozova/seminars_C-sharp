// Напишите программу, которая выводит случайное число из отрезка [10, 9999]
//и показывает наибольшую цифру числа.
// 7812 -> 8 
// 1213-> 3 
// 845 -> 8

int randValue = new Random().Next(10, 10000); // выводим случайное значение
int maxNumber = 0;
int value = randValue;

while (randValue > 0)
{
    int remains = randValue % 10;
    if (maxNumber < remains)
        maxNumber = remains;
    randValue = randValue / 10;
}

Console.WriteLine($"{value} -> {maxNumber}");