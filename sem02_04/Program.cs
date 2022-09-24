// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.Write("Введите число > ");
int value = int.Parse(Console.ReadLine() ?? "0");
bool remains = (value % 7 == 0) && (value % 23 == 0);
if (remains)
{
    Console.WriteLine($"{value} -> да");
}
else
{
    Console.WriteLine($"{value} -> нет");
}