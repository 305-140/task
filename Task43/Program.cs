﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("y = k1 * x + b1, y = k2 * x + b2");
Console.WriteLine("Введите  k1,b1,k2,b2:");
double numk1 = Convert.ToInt32(Console.ReadLine());
double numb1 = Convert.ToInt32(Console.ReadLine());
double numk2 = Convert.ToInt32(Console.ReadLine());
double numb2 = Convert.ToInt32(Console.ReadLine());

double[] array = CommonPoint(numk1, numb1, numk2, numb2);
Console.WriteLine("Точка пересечения: " + array[0]+";"+array[1]);

double[] CommonPoint(double k1, double b1, double k2, double b2)
{
    double[] mass = new double[2] {0.001,0.001};
    if (k1 == k2) return mass;
    else
    {
        mass[0] = ((b2 - b1)/(k1 - k2));
        mass[0] = Math.Round((double) mass[0], 2);
        // x = Math.Round(x, 2, MidpointRounding.ToZero);
        mass[1] = k1 * mass[0] + b1;
        // y = Math.Round(y, 2, MidpointRounding.ToZero);
        return mass;
    }
}