// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
Console.WriteLine("Введите координаты точки A(х,y):");
int numX1 = Convert.ToInt32(Console.ReadLine());
int numY1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B(х,y):");
int numX2 = Convert.ToInt32(Console.ReadLine());
int numY2 = Convert.ToInt32(Console.ReadLine());

// double d = 5.09998774;
// double dRound = Math.Round(d, 2, MidpointRounding.ToZero);
Console.WriteLine(Math.Round(Distance(numX1, numY1, numX2, numY2), 2, MidpointRounding.ToZero));

double Distance(int x1, int y1, int x2, int y2)
{
    double dis = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    return dis;
}





// Console.Write("Введите координаты x точки a: ");
// int xa = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координаты y точки a: ");
// int ya = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координаты x точки b: ");
// int xb = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координаты y точки b: ");
// int yb = Convert.ToInt32(Console.ReadLine());

// double result = Distance(xa, ya, xb, yb);
// Console.Write(Math.Round(result, 2, MidpointRounding.ToZero));

// double Distance(int x1, int y1, int x2, int y2)
// {
//     double sumSquare = ((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1));
//     double res = Math.Sqrt(sumSquare);
//     return res;
// }

