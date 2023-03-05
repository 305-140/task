// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

int[,] array2d = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(array2d);

Console.WriteLine("Введите позицю: ");
int xNum = Convert.ToInt32(Console.ReadLine());
int yNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{xNum}, {yNum} -> "+SearchPosition(xNum, yNum, array2d));

string SearchPosition(int x, int y, int[,] arr2d)
{
    if (x < 0 || x >= arr2d.GetLength(0) || y < 0 || y >= arr2d.GetLength(1)) return "такого элемента в массиве нет".ToString();
    else return arr2d[x,y].ToString();
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
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}, ");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine("]");
    }
}
