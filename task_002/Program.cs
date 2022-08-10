/*
    Напишите программу, которая выводит третью цифру заданного числа 
    или сообщает, что третьей цифры нет.
    645 -> 5
    78 -> третьей цифры нет
    32679 -> 6
*/
 //Console.Clear();

 void GetNumber(string strNumber)
 {
    char[] chars = strNumber.ToCharArray();
     if (chars.Length < 3)
        {
            Console.WriteLine($"В {strNumber} нет третьей цифры!");
        }
        else
        {
            Console.WriteLine($"{strNumber} -> {chars[2]}");
        }
 }

// Вводим число
 Console.Write("Введите число: ");
 string strNumber = Console.ReadLine();
 GetNumber(strNumber);

