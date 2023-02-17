// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки A(х,y,z):");
int numX1 = Convert.ToInt32(Console.ReadLine());
int numY1 = Convert.ToInt32(Console.ReadLine());
int numZ1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B(х,y,z):");
int numX2 = Convert.ToInt32(Console.ReadLine());
int numY2 = Convert.ToInt32(Console.ReadLine());
int numZ2 = Convert.ToInt32(Console.ReadLine());

// double d = 5.09998774;
// double dRound = Math.Round(d, 2, MidpointRounding.ToZero);
Console.WriteLine(Math.Round(Distance(numX1, numY1, numZ1, numX2, numY2, numZ2), 2, MidpointRounding.ToZero));

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double dis = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return dis;
}
