// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите размер матрицы m1xn1: ");
Console.Write("m = ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("n = ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер матрицы m2xn2: ");
Console.Write("m = ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.Write("n = ");
int n2 = Convert.ToInt32(Console.ReadLine());
// int m1 = 4;
// int n1 = 2;
// int m2 = 2;
// int n2 = 3;
int[,] matrixOne = CreateMatrixRndInt(m1, n1, 2, 4);
int[,] matrixTwo = CreateMatrixRndInt(m2, n2, 2, 4);

PrintTwoMatrix(matrixOne, matrixTwo);
bool CanMultiply = n1 == m2;

if (CanMultiply)
{
    int[,] matrixTree = MultiplicationTwoMatrixs(matrixOne, matrixTwo);
    PrintMatrix(matrixTree);
}
else
{
    System.Console.WriteLine("ERROR(нельзя перемножить 2 матрицы): Учите мат часть перемножения двух матриц.");
}

int[,] MultiplicationTwoMatrixs(int[,] arr2d1, int[,] arr2d2)
{
    int[,] arr2d = new int[arr2d1.GetLength(0), arr2d2.GetLength(1)];
    for (int i = 0; i < arr2d1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2d2.GetLength(1); j++)
        {
            for (int k = 0; k < arr2d2.GetLength(0); k++)
            {
                arr2d[i, j] = arr2d[i, j] + arr2d1[i, k] * arr2d2[k, j];
            }
        }
    }

    return arr2d;
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

void PrintTwoMatrix(int[,] matrix1, int[,] matrix2) //мега вывод матриц разных размеров
{
    int lengthRows = matrix1.GetLength(0) > matrix2.GetLength(0) ? matrix1.GetLength(0) : matrix2.GetLength(0);

    for (int i = 0; i < lengthRows; i++)
    {
        if (i < matrix1.GetLength(0))
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                if (j < matrix1.GetLength(1) - 1) Console.Write($"{matrix1[i, j],3} ");
                else Console.Write($"{matrix1[i, j],3} |");
            }
        }
        else
        {
            string Emp = " ";
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                Console.Write($"{Emp,3} ");
            }
            Console.Write("|");
        }
        if (i < matrix2.GetLength(0))
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                if (j < matrix2.GetLength(1) - 1) Console.Write($"{matrix2[i, j],3} ");
                else Console.Write($"{matrix2[i, j],3}");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
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