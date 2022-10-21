// Напишите программу,
// 1. которая выводит случайное трёхзначное число 
// 2. и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98


// int number = new Random().Next(100, 1000);
// Console.WriteLine($"Случайное трёхзначное число из отрезка 100 - 1000 => {number}");

// int firstDigit = number / 100;
// int thirDigit = number % 10;
// int digit = firstDigit * 10 + thirDigit;
// Console.WriteLine($"Полученное число {digit}");


int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трёхзначное число из отрезка 100 - 1000 => {number}");

int DelSecondDigit(int num)
{
    int firstDigit = number / 100;
    int thirDigit = number % 10;
    return firstDigit * 10 + thirDigit;

}

int result = DelSecondDigit( number );
Console.WriteLine($"Полученное число {result}");