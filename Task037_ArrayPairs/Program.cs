// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

void FillArray(int[] array, int A, int B)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(A, B);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] array = new int[9];
FillArray(array, 0, 10);
PrintArray(array);

int[] result = new int[(array.Length + 1) / 2];

result[result.Length - 1] = array[array.Length / 2];

for (int i = 0; i < array.Length / 2; i++)
{
    result[i] = array[i] * array[array.Length - 1 - i];
}

PrintArray(result);