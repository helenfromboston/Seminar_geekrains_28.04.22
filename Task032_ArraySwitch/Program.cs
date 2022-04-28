// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

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

for (int i = 0; i < array.Length; i++)
{
    array[i] = -array[i];
}

PrintArray(array);