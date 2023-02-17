// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9999 && number < 100000)
{
    if (number == reNumber(number))   Console.WriteLine(reNumber(number)+" -> да");
    else Console.WriteLine(number+" -> нет");
}
else Console.WriteLine("Это не пятизначное число ");

//Console.WriteLine(reNumber(number));

int reNumber(int num)
{
    int reNum = 0;
    while (num > 0)
    {
        reNum = reNum * 10 + num % 10;
        num = num / 10;
    }
    return reNum;
}