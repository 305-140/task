// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите размер матрицы mxn: ");
Console.Write("m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array2d = CreateMatrixRndInt(m, n, -10, 10);
PrintMatrix(array2d);
int[] array = SummRows(array2d);
PrintArray(array);
PrintMinSummArray(array);



void PrintMinSummArray(int[] arr)
{
    int min = arr[0];
    for (int i = 1; i < arr.Length; i++) //минимальное значение может быть одно, но оно может повторяться
    {
        if (min>=arr[i])
        {
            min = arr[i];
        }
    }
    for (int i = 0; i < arr.Length; i++) //просмотрим массив и нарспечатаем все строчки с мин значением
    {
        if (arr[i] == min)
        {
            System.Console.WriteLine($"Наименьшая сумма элементов: {i} строка");
        }
    }
}

int[] SummRows(int[,] matrix)
{
    int summ = 0;
    int[] array = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summ += matrix[i, j];
        }
        array[i] = summ;
        summ = 0;
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.Write("|");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i],3}, ");
        else Console.Write($"{arr[i],3}");
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3} ");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine("|");
    }
    Console.WriteLine();
}
