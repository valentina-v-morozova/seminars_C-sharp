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

int value = Prompt("Введите номер дня недели > ");

if (value < 0 || value > 7)
{
    System.Console.WriteLine("Такого дня не существует");
}
else
{
    if (value == 1)
    {
        System.Console.WriteLine("понедельник");
    }
    if (value == 2)
    {
        System.Console.WriteLine("вторник");
    }
    if (value == 3)
    {
        System.Console.WriteLine("среда");
    }
    if (value == 4)
    {
        System.Console.WriteLine("четверг");
    }
    if (value == 5)
    {
        System.Console.WriteLine("пятница");
    }
    if (value == 6)
    {
        System.Console.WriteLine("суббота");
    }
    if (value == 7)
    {
        System.Console.WriteLine("воскресенье");
    }
}