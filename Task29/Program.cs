/* Задача 29: Напишите программу, которая 
// 1) задаёт массив из 8 элементов и 
// 2) выводит их на экран.
// // 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33] */

int[] array = new int[8];
Console.WriteLine("Введите значения элементов массива:");
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{i + 1}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());

}

for (int i = 0; i < array.Length; i++)
{
    Console.Write($" {array[i]}");
}
Console.WriteLine();

// string[] sa1 = new string[3];
// sa1[0] = "abc";
// sa1[1] = "def";
// sa1[2] = "ghi";
// Console.WriteLine($"sa1: {sa1[0]}, {sa1[1]}, {sa1[2]}");

// double[] da1 = new double[3] { 0.1, 0.2, 0.3 };
// Console.WriteLine($"da1: {da1[0]}, {da1[1]}, {da1[2]}");