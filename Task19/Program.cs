// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да


Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool Palindrom(int num)
{
    int firstDigit = num / 10000;
    // Console.WriteLine($"{firstDigit}");

    int secondDigit = num / 1000 % 10;
    // Console.WriteLine($"{secondDigit}");

    int fourthDigit = num % 100 / 10;

    // Console.WriteLine($"{fourthDigit}");

    int fifthDigit = num % 10;
    // Console.WriteLine($"{fifthDigit}");

    if (firstDigit == fifthDigit && secondDigit == fourthDigit) return true;
    return false;
}

bool result = Palindrom(number);
if (result)
{
    Console.WriteLine("ДА");
}
else
{
    Console.WriteLine("НЕТ");
}

