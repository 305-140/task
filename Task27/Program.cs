// Задача 27:
// 1).Напишите программу, которая 
// 2).принимает на вход число и 
// 3).выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());
int sum = SumNumbers(number);
Console.WriteLine($"Сумма цифр в числе {number} = {sum}");


int SumNumbers(int num)
{
    int a =0;
    int b=0;
    while (b != 0)
    {
        a = a + num % 10;
        b = num /10;
    }
    return 0;
}

