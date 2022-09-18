//Напишите программу, которая на вход принимает число и выдаёт его квадрат
//(число умноженное на само себя).
Console.Write("Введите число > ");
string strValue; //объявляем тип переменной
strValue = Console.ReadLine() ?? "0"; //если ничего не ввели - присваиваем 0
int value = int.Parse(strValue); //переводим значение из консоли в int

int result = value * value;
Console.WriteLine($"Квадрат числа {value} равен {result}");