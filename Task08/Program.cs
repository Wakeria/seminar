// Напишите программу,
// 1. которая на вход принимает число (N),
// 2. а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.WriteLine("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Count = 2;

if (number <= 0)
{
    Console.WriteLine("Вы ввели неподходящее число");
}
else
{
    Console.WriteLine("все чётные числа от 1 до N");
while (Count <= number)
{
    if (Count % 2 < 1)
    {
        Console.Write($"{Count}, ");
    }
    Count++;
}
}