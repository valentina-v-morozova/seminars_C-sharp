// Напишите программу, которая будет выдавать название дня недели по заданному номеру

// Ввод данных из консоли по приглашению
int Prompt(string message)
{
    System.Console.Write(message);        //Вывод приглашения
    string strValue;                      //Объявляем переменной для ввода строки
    strValue = Console.ReadLine() ?? "0"; //Вводим строку с консоли (можно ввести только строку)
    int value = int.Parse(strValue);      //Преобразование строки в целое число
    return value;
}

string[] days = {"понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье"};

int value = Prompt("Введите номер дня недели > ");

if (value < 0 || value > 7)
{
    System.Console.WriteLine("Такого дня не существует");
}
else{}
int daysValue = value -1;
System.Console.WriteLine($"{value} -> {days[daysValue]}");