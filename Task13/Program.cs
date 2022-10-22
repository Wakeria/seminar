// Задача 13: Напишите программу,
//  которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//  Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int number2 = number;
if (number > 100)
{
    while (number2 > 1000)
    {
        number2 = number2 / 10;

    }
    int num = number2 % 10;

Console.WriteLine($"{num}");

}
else
{
    Console.WriteLine("третьей цифры нет");
}
