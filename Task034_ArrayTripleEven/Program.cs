// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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

int[] array = new int[10];
FillArray(array, 100, 1000);
PrintArray(array);

int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0) count++;
}

Console.WriteLine($"В массиве {count} чётных чисел");