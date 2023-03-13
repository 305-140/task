// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("ФУНКЦИЯ АККРМАНА");
Console.Write("Введите m:");
int numberM = int.Parse(Console.ReadLine());
Console.Write("Введите n:");
int numberN = int.Parse(Console.ReadLine());
if (numberM > 0 && numberN > 0)
{
    Console.WriteLine($"m = {numberM}, n = {numberN} -> A(m,n) = {AkkermanFunction(numberM,numberN)}");
}
else
{
    System.Console.WriteLine("Числа m и n должны быть неотрицательными!");
}

int AkkermanFunction(int n, int m)
{
    if (n == 0) return m + 1;
    else if (m == 0) return AkkermanFunction(n-1,1);
    else return AkkermanFunction(n-1, AkkermanFunction(n,m-1));
}
