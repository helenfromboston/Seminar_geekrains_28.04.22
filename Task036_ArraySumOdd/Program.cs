// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19 // [-4, -6, 89, 6] -> 0

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
FillArray(array, -100, 100);
PrintArray(array);

int result = 0;

for (int i = 0; i < array.Length; i++)
{
    if (i % 2 == 0) result += array[i];
}

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях, равна {result}");