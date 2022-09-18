// Напишите программу, которая на вход принимает два числа и проверяет,
// является ли первое число квадратом второго.

// Ввод числа из консоли по приглашению
int Prompt(string message)
{
    System.Console.Write(message);        //Вывод приглашения
    string strValue;                      //Объявляем переменной для ввода строки
    strValue = Console.ReadLine() ?? "0"; //Вводим строку с консоли (можно ввести только строку)
    int value = int.Parse(strValue);      //Преобразование строки в целое число
    return value;
}

int firstValue = Prompt("Введите первое число > ");
int secondValue = Prompt("Введите второе число > ");

if(secondValue == firstValue*firstValue)
{
System.Console.WriteLine("- > да");
}
else
{
System.Console.WriteLine("- > нет");
}