// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.WriteLine("Массив случайных вещественных чисел:");
double[] array = new double[8];
int minDigit = 1;
int maxDigit = 99;

array = CreateArrayRndDouble(8, minDigit, maxDigit);
PrintArrayDouble(array);

Console.WriteLine("Max-Min = " + DifferenceMaxMinOfArray(array));

double DifferenceMaxMinOfArray(double[] arr)
{
    double maxNum = arr[0];
    double minNum = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > maxNum) maxNum = arr[i];
        if (arr[i] < minNum) minNum = arr[i];
    }
    return maxNum - minNum;
}

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(arr[i], 1, MidpointRounding.ToZero);
    }
    return arr;
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}