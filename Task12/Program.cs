// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно
Console.WriteLine("Введите а и б:");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());

if (Briefly(numberA, numberB) == 0) Console.WriteLine($"{numberA}, {numberB} -> кратно");
else Console.WriteLine($"{numberA}, {numberB} -> не кратно, остаток {Briefly(numberA, numberB)}");


int Briefly(int a, int b)
{
    return Convert.ToInt32(a % b);
}
