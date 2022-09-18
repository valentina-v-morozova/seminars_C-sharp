//Напишите программу вычисления функции:
 //x = f(a) - функция куба

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
int result = value * value* value;
Console.WriteLine($"Куб числа {value} равен {result}");//Вывод результата