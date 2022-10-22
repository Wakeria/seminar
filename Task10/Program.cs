// // Напишите программу,
// // 1. которая принимает на вход трёхзначное число 
// // 2. и на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// // 456 -> 5
// // 782 -> 8
// // 918 -> 1

Console.WriteLine("введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SecondDigit(int num)
{

    int result = number / 10 % 10;

    return result;
}

int secondDigit = SecondDigit(number);
Console.WriteLine($"вторая цифра числа: {secondDigit} ");