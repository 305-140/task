// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Массив случайных чисел:");
double[] array = new double[8];
int minDigit = 10;
int maxDigit = 99;

array = CreateArrayRndDouble(8, minDigit, maxDigit);
PrintArrayDouble(array);

Console.WriteLine("Сумма элементов на нечетных позициях = " + SumNumbersOddPositions(array));

int SumNumbersOddPositions(double[] arr)
{
    int sumNumber = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if ((i+1) % 2 != 0)
        {
            sumNumber+=(int) arr[i];
           // Console.WriteLine(i+"-"+array[i]+"-"+sumNumber);
        }
    }
    return sumNumber;
}

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(arr[i], 0, MidpointRounding.ToZero);
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