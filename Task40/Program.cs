// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите A,B,C: ");
int sizeA = Convert.ToInt32(Console.ReadLine());
int sizeB = Convert.ToInt32(Console.ReadLine());
int sizeC = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(VerificationParties(sizeA, sizeB, sizeC));

string VerificationParties(int a, int b, int c)
{
    if (a + b < c || b + c < a || c + a < b) return "не существует";
    else return "существует";
}
