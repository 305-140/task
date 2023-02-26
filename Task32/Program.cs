// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

// 32 задача
int[] arrayFill(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return array;
}


void arrayChange(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * (-1);
    }
}


void printArray(int[] array)
{
    System.Console.WriteLine("[ " + String.Join(", ", array) + " ]");
}

int[] array = arrayFill(6, -3, 3);


printArray(array);
arrayChange(array);
printArray(array);


// Другой пример
double[] CreateArray(double[] arr, int min, int max)
{
    int count = arr.Length;
    Random rnd = new Random(); //создает псевдослучайное число по системному времени 15мс
    for (int i = 0; i < count; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(double[] arr)
{
    int count = arr.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

void ModifyArray(double[] arr)
{
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        arr[i]*=(-1);
    }
}

Console.Clear();

int quantity = 10;
int min = -10;
int max = 10;

double[] array = new double[quantity];
array = CreateArray(array, min, max);

Console.Write("Массив -> ");
PrintArray(array);

Console.WriteLine();
Console.Write("Измененный массив -> ");
ModifyArray(array);
PrintArray(array);

// Еще

int Prompt(string message)
{
    Console.Write(message);
    int cc = Convert.ToInt32(Console.ReadLine());
    return 0;
}

int[] CreateArray(int[] arr, int min, int max)
{
    int count = arr.Length;
    Random rnd = new Random(); //создает псевдослучайное число по системному времени 15мс
    for (int i = 0; i < count; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    int count = arr.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

bool FindNum(inte[] arr, int number)
{
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        if (arr[i] == number) return true;
    }
    return false;
}

Console.Clear();
int quantity = 10; 
int min = -999; 
int max = 999; 
int[] array = new int[quantity];
array = CreateArray(array, min, max);
Console.Write("Массив -> ");
PrintArray(array);
int number = Prompt("Введите искомое число: ");
if (FindNum(array, number) == true) Console.WriteLine($"Искомое число найдено");
else Console.WriteLine($"Искомое число не найдено");

// 32 еще
