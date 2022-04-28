// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет-3; массив [6, 7, 19, 345, -3] -> да

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
}

int[] array = new int[5];
FillArray(array, -100, 100);
PrintArray(array);
Console.WriteLine();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

bool exist = false;

for (int i = 0; i < array.Length; i++)
{
    if (number == array[i])
    {
        exist = true;
        break;
    }
}

if (exist)
{
    Console.WriteLine($"Заданное число {number} присутствует в массиве");
}
else
{
    Console.WriteLine($"Заданное число {number} не присутствует в массиве");
}