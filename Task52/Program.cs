// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array2d = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(array2d);
double[] array = ArithmeticMean(array2d);

Console.WriteLine("Среднее арифметическое каждого столбца: ");
PrintArray(array);

double[] ArithmeticMean(int[,] arr2d)
{
    int summ = 0;
    double[] arr = new double[arr2d.GetLength(1)];
    for (int j = 0; j < arr2d.GetLength(1); j++)
    {
        for (int i = 0; i < arr2d.GetLength(0); i++)
        {
            summ += arr2d[i, j];
        }
        arr[j] = Math.Round((double) summ / arr2d.GetLength(0),2,MidpointRounding.ToEven); //
        
        summ = 0;
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("|");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i],6} ");
        else Console.Write($"{arr[i],6}");
    }
    Console.WriteLine("|");
}

int[,] CreateMatrixRndInt(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],6} ");
            else Console.Write($"{matrix[i, j],6}");
        }
        Console.WriteLine("|");
    }
}
