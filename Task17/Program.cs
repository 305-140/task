// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

Console.WriteLine("Введите координаты точки(Х,Y):");
int numX = Convert.ToInt32(Console.ReadLine());
int numY = Convert.ToInt32(Console.ReadLine());

if (Quarter(numX,numY) != 0) Console.WriteLine("Координаты соответствуют четверти: "+Quarter(numX,numY));
else Console.WriteLine("Введены некоректные координаты!");

int Quarter(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}