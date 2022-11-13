// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int numbers = Convert.ToInt32(Console.ReadLine());
int summa = 0;
int SumNum(int num, int sum)
{
    int count = 0;
    while (num > 0)
    {
        count = count + num % 10;
        num = num / 10;
        sum = count + num;
    }
    return sum;
}
int sumNum = SumNum(numbers, summa);
Console.WriteLine($"Сумма цифр в заданом числе = {sumNum}");