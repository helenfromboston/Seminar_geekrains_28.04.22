// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1 // [1, 2, 3, 6, 2] -> 0 // [10, 11, 12, 13, 14] -> 5

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void FillArray(int[] array, int A, int B)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(A, B);
    }
}

int[] array = new int[123];
FillArray(array, 0, 200);
PrintArray(array);

int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= 10 && array[i] <= 99) count++;
}

Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [10,99], равно {count}");