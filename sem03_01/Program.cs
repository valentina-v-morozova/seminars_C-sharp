// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 или Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int Prompt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

bool ValidateCoords(int x, int y) //Валидация данных
{
    if (!(x == 0 || y == 0)) // (!(x == 0) && !(y == 0)) или (x != 0 && y != 0)
    {
        return true;
    }
    Console.WriteLine("Точка лежит на одной из осей");
    return false;
}

void DeterminateQuarter(int x, int y)
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("Первая четверть");
    }
    if (x < 0 && y > 0)
    {
        Console.WriteLine("Вторая четверть");
    }
    if (x < 0 && y < 0)
    {
        Console.WriteLine("Третья четверть");
    }
    if (x > 0 && y < 0)
    {
        Console.WriteLine("Четвертая четверть");
    }
}

int x = Prompt("Введите x > ");
int y = Prompt("Введите y > ");
if (ValidateCoords(x, y))
{
    DeterminateQuarter(x, y);
}
