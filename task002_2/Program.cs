/*
    Напишите программу, которая выводит третью цифру заданного числа 
    или сообщает, что третьей цифры нет.
    645 -> 5
    78 -> третьей цифры нет
    32679 -> 6
*/

Console.Clear();

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result;

if (number < 100)
{
    result = -1;
    PrintResult(result);
}
else if (number < 1000)
{
    result = GetNumberOfEnd(number);
    PrintResult(result);
}
else if (number > 1000)
{
    result = StepDivisionNumber(number);
    result = GetNumberOfEnd(result);
    PrintResult(result);
}


int GetNumberOfEnd(int number)
{
    number =  number % 10;
    return number;
}

int StepDivisionNumber(int number)
{
    if (number < 1000)
    {
        return number;
    }
    return StepDivisionNumber(number / 10);
}

void PrintResult(int result)
{
    if (result == -1)
    {
        Console.WriteLine($"В числе {number} третьей цифры нет!");
    }
    else
    {
        Console.WriteLine($"Третья цифра с начала в числе {number} -> {result}");
    }
}

