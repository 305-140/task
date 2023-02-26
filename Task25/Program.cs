// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите числа (A и B): ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());

int AB = IntPow(numberA,numberB);

Console.WriteLine($"число A в натуральной степеньи B = {AB}");


int IntPow(int a, int b) //a=2,b=5;
{
    int construction = 1;
    int i = 1;
    while (i <= b)
    {
        i = i + 1; //счетчик
        construction = construction * a;
    }
    return construction;
}
