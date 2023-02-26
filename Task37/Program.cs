// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] СompositionNumbers(int[] arr)
{
    int size = arr.Length / 2;
    if (arr.Length % 2 != 0) size += 1;

    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {                                                   // 0 1 2 3 4
        newArray[i] = arr[i] * arr[arr.Length - 1 - i]; // 3,4,2,6,1  
    }
    if (newArray.Length % 2 != 0)
        newArray[newArray.Length - 1] = arr[size-1];
    return newArray;
}

int[] array = CreateArrayRndInt(8, 0, 10);
int[] array2 = СompositionNumbers(array);
PrintArray(array);
Console.WriteLine();
PrintArray(array2);