/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()); 

void GetThirdDigit(int number)
{
    if (number >= 100)
    {
        while (number > 999) number = number / 10;            
        // 67816 / 10 = 678
        Console.WriteLine(number % 10);
        // 678 % 10 = 67,8
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
}

GetThirdDigit(number);


