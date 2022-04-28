// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
// [3 7 22 2 78] -> 76

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void FillArray(double[] array, int A, int B)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(A, B); 
    }
}

double Max(double[] array)
{
    int maxpos = 0;
    double max = array[maxpos];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > array[maxpos])
        {
            max = array[i];
            maxpos = i;
        }
    }
    return max;
}

double Min(double[] array)
{
    int minpos = 0;
    double min = array[minpos];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < array[minpos])
        {
            min = array[i];
            minpos = i;
        }
    }
    return min;
}

double[] array = new double[10];
FillArray(array, 0, 100);
PrintArray(array);
Console.WriteLine($"Разница между максимальным элементом массива ({Max(array)}) и минимальным ({Min(array)}) равна {Max(array) - Min(array)}");