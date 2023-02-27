// Задача 27:
// Напишите программу, которая 
// 1).принимает на вход число и 
// 2).выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());
int sum = SumNumbers(number);
Console.WriteLine($"Сумма цифр в числе {number} = {sum}");


int SumNumbers(int num)
{
    int summ = 0;
    int digit = 0;

    while (num != 0 )
    {
        digit = num % 10;
        summ = summ + digit;
        num = num / 10;

    }
    return summ;
}

