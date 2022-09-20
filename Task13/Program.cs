/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()); 

void GetThirdDigit(int num)
{
    if (num >= 100)
    {
        while (num > 999) num = num / 10;            
        // 51678 / 10 = 516
        Console.WriteLine(num % 10);
        // 516 % 10 = 56,6
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
}

GetThirdDigit(number);


