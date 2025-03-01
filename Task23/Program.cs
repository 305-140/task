﻿// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число N:");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0) TableNum(number);
else Console.WriteLine("Введено некорректное число!");

void TableNum(int num)
{
    for (int i = 1; i <= num; i++)
    {
       Console.WriteLine($"{i, 7} -> {i*i*i,7}"); 
    }
}