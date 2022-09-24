// Напишите программу, которая будет принимать на вход пять чисел и
// выводить сумму и среднее арифметическое этих чисел.
// 2, 5, 6, 8, 1 -> сумма 22, среднее 4,4

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}

int firstNumber = Prompt("Введите первое число > ");
int secondNumber = Prompt("Введите второе число > ");
int thirdNumber = Prompt("Введите третье число > ");
int forthNumber = Prompt("Введите четвертое число > ");
int fifthNumber = Prompt("Введите пятое число > ");
int sum = firstNumber + secondNumber + thirdNumber + forthNumber + fifthNumber;
double average = sum / 5;
System.Console.WriteLine($"{firstNumber}, {secondNumber} {thirdNumber}, {forthNumber} {fifthNumber} -> сумма {sum}, среднее {average}");