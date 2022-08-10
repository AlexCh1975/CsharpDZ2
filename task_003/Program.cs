/*
    Напишите программу, которая принимает на вход цифру, 
    обозначающую день недели, и проверяет, является ли этот день выходным.
    6 -> да
    7 -> да
    1 -> нет
*/  

//Console.Clear();

Console.Write("Введите номе дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());
GetDayStatus(day);

void GetDayStatus(int day)
{
    if (0 >= day || day > 7)
    {
        Console.WriteLine($"{day} такого дня недели нет!");
    }
    else if (day == 6 || day == 7)
    {
        Console.WriteLine($"{day} 'ДА' выходной день!");
    } 
    else 
    {
        Console.WriteLine($"{day} 'НЕ' выходной день!");
    }
}


