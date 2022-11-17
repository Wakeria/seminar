
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] CreateArrayRndInt(int size, int mint, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(mint, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int SummaNumbersElements(int[] array)
{
    int summ = 0;

    for (int i = 1; i < array.Length; i = i + 2)
    {
        summ = summ + array[i];
    }
    return summ;
}

int[] arr = CreateArrayRndInt(7, -10, 10);
PrintArray(arr);
int result = SummaNumbersElements(arr);
Console.WriteLine($"суммa элементов, стоящих на нечётных позициях = {result}");