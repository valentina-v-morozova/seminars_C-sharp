// Напишите программу, которая на вход принимает значение, а  на выходе показывает обратное значение.
// 1 -> 1 
// 2 -> 0.5
// 0.25 -> 4

// Ввод числа из консоли по приглашению
double Prompt(string message)
{
    System.Console.Write(message);        //Вывод приглашения
    string strValue;                      //Объявляем переменной для ввода строки
    strValue = Console.ReadLine() ?? "0"; //Вводим строку с консоли (можно ввести только строку)
    double value = int.Parse(strValue);      //Преобразование строки в целое число
    return value;
}

double value = Prompt("Введите число > ");
if (value == 0)
{
    Console.WriteLine("Нельзя делить на ноль");
}
else
{
double result = 1/value;

Console.WriteLine($"{value} -> {result}");//Вывод результата
}