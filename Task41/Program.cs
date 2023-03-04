// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите M: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array;
array = ArrayM(number);

PrintArray(array);
Console.WriteLine($" -> {Counts(array)}");


int Counts(int[] arr)
{
    int num = 0;
    for (int i = 0; i < arr.Length; i++)
    {
       if (arr[i]>0)  num++;
    }
    return num;
}

int[] ArrayM(int num)
{
    int[] arr = new int[num];
    for (int i = 0; i < num; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}


