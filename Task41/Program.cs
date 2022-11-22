// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3


Console.Write("Сколько чисел вы хотите ввести =");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ваши числа:");
int[] array = new int[num];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
    if (array[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"положительных чисел => { count}") ;