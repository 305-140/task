// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if ((number / 100 != 0)&&(number / 1000 == 0))
{
int secondDigit = (number % 100) / 10;
Console.WriteLine("Вторая цифра числа = "+secondDigit);
}
else Console.WriteLine("Число должно быть трехзначным");


