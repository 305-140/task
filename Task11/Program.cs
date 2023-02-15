// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int Number = new Random().Next(100,1000);
Console.WriteLine($"Случайное число из отрезка 10--99 = {Number}");

int firstDigit = Number / 100;
//int secondDigit = (Number % 100) / 10;
int lastDigit = Number % 10;

int newNumber = firstDigit *10 + lastDigit;

Console.WriteLine(newNumber);