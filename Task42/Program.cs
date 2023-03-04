// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите десятичное число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{number} -> " + Convert.ToString(number, 2));
Console.WriteLine($"{number} -> {DecToBin(number)}");

string DecToBin(int num)
{
    string temp = "";
    while (num > 1)
    {
        temp = num % 2 + temp;
        num = num / 2;
    }
    temp = num + temp;
    return temp;
}

