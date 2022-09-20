// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трёхзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

int GetSecondDigit(int number)
{
    int result = number / 10 % 10;
    return result;
}
if(number > 99 && number < 1000)
{
    Console.WriteLine(GetSecondDigit(number)); 
}
else
{
    Console.WriteLine("Вы ввели некорректное число, введите трёзначное число!"); 
}


