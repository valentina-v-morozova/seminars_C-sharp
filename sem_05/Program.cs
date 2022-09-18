// Напишите программу вычисления модуля числа.
//	2 -> 2
//	-3 -> 3
//	-7 -> 7

// Ввод числа из консоли по приглашению
int Prompt(string message)
{
    System.Console.Write(message);        //Вывод приглашения
    string strValue;                      //Объявляем переменной для ввода строки
    strValue = Console.ReadLine() ?? "0"; //Вводим строку с консоли (можно ввести только строку)
    int value = int.Parse(strValue);      //Преобразование строки в целое число
    return value;
}

int value = Prompt("Введите число > ");
int result;
if (value < 0)
{
result = -value;
}
else
 {
result = value;
}   
Console.WriteLine($"{value} -> {result}");//Вывод результата