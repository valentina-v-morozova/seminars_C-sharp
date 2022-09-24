// Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если число 2 не кратно числу 1,
// то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}

int firstNumber = Prompt("Введите первое число > ");
int secondNumber = Prompt("Введите второе число > ");
int value = firstNumber % secondNumber;

if (value != 0)
{
Console.WriteLine($"{firstNumber}, {secondNumber} -> не кратно, остаток {value}");
}
else
{
    Console.WriteLine($"{firstNumber}, {secondNumber} -> кратно");
}