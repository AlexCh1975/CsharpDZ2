/*
    Задача 10: Напишите программу, которая принимает на вход 
    трёхзначное число и на выходе показывает вторую цифру этого числа.

    456 -> 5
    782 -> 8
    918 -> 1
*/

Console.Clear();

int TransformNumber(int number)
{
    int number1 = number % 100;
    int number2 = number % 10;
    return (number1 - number2) / 10;
}

Console.WriteLine("Введите 3-х значное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int transformNumber = TransformNumber(number);

Console.WriteLine(transformNumber);

