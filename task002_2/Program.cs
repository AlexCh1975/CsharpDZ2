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

if (number < 100)        // Отсекаем цифры меньше трехзначных
{
    result = -1;
    PrintResult(result);
}
else if (number < 1000)   // Если число трехзначное забираем последнюю цифру
{
    result = GetNumberOfEnd(number);
    PrintResult(result);
}
else if (number > 1000)   // Если число > трехзначного -> делаем трехзначным -> забираем третью цифру
{
    result = StepDivisionNumber(number);
    result = GetNumberOfEnd(result);
    PrintResult(result);
}

// Из трехзначного числа получаем третью цифру
int GetNumberOfEnd(int number)
{
    number =  number % 10;
    return number;
}

// Из числа > трехзначеого получаем трехзначное
int StepDivisionNumber(int number)
{
    if (number < 1000)
    {
        return number;
    }
    return StepDivisionNumber(number / 10);
}

// Вывод результата
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

