// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите а");
int numberA = Convert.ToInt32(Console.ReadLine());

if (Briefly(numberA)) Console.WriteLine("-> да");
else Console.WriteLine("-> нет");

bool Briefly(int num)
{
    return (num % 7 == 0 )&&(num % 23 == 0) ? true : false;
}