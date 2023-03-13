// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите M:");
int numberM = int.Parse(Console.ReadLine());
Console.Write("Введите N:");
int numberN = int.Parse(Console.ReadLine());

Console.WriteLine($"Сумма от {numberM} до {numberN} равна = {SummNatural(numberM,numberN)}");

int SummNatural(int m, int n)
{
    if (m < n)
    {
        return m + SummNatural(m+1,n);
    }
    else if (m>n)
    {
        return m + SummNatural(m-1,n);
    }
    else
    {
        return m;
    }
}
