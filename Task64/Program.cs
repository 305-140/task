// Задача 64: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите N:");
int number = int.Parse(Console.ReadLine());
if (number > 0)
{
    PrintNumber(number);
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Число N должно быть натуральным");
    Console.ForegroundColor = ConsoleColor.White;
}

Console.WriteLine();

void PrintNumber(int num)
{
    if (num == 0) return;
    Console.Write($"{num} ");
    PrintNumber(num - 1);
}