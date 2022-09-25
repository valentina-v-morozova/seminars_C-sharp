// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

int Prompt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

bool ValidateCoords(int inputNum) //Валидация данных
{
    if (inputNum > 0 && inputNum < 5)
    {
        return true;
    }
    Console.WriteLine("Нет такой четверти");
    return false;
}

void DeterminateQuarter(int inputQuarter)
{
    if (inputQuarter == 1)//(x > 0 && y > 0)
    {
        Console.WriteLine("x > 0 && y > 0");
    }
    if (inputQuarter == 2)//(x < 0 && y > 0)
    {
        Console.WriteLine("x < 0 && y > 0");
    }
    if (inputQuarter == 3) //(x < 0 && y < 0)
    {
        Console.WriteLine("x < 0 && y < 0");
    }
    if (inputQuarter == 4)//(x > 0 && y < 0)
    {
        Console.WriteLine("x > 0 && y < 0");
    }
}

int qNumber = Prompt("Введите Номер четверти > ");

if (ValidateCoords(qNumber))
{
    DeterminateQuarter(qNumber);
}
