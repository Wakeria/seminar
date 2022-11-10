// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumDigit(int numDigit)
{

    int count = 0;
    while (numDigit > 0)
    {
        numDigit = numDigit / 10;
        count++;
    }
    return count > 0 ? count : 1;
}
int sumDigit = SumDigit(num);
Console.WriteLine($"Количество цифр в числе = {sumDigit}");

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int SumDigit(int numDigit)
// {
// numDigit = Math.Abs(numDigit);
// int count = 0;
// while (numDigit > 0)
// {
// numDigit = numDigit / 10;
// count++;
// }
// return count > 0 ? count : 1;
// }
// int sumDigit = SumDigit(num);
// Console.WriteLine($"Количество цифр в числе = {sumDigit}");


// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int countNum = CountNum(number);

// 1 вариант
// // int CountNum(int num)
// // {
// //     int count = 0;

// //     while (num > 0)
// //     {
// //         num /= 10;
// //         count++;
// //     }
// //     return count;
// // }

// 2 вариант
// int CountNum(int num)
// {
//     int count = 0;

//     for (int i = num; i > 0; i /= 10)
//     {
//         count++;
//     }
//     return count;
// }

// Console.WriteLine($"У вашего числа {countNum} цифры");