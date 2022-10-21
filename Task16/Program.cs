// Напишите программу,
// 1.  которая принимает на вход два числа 
// 2. и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите два числа");
Console.Write("Первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 * number1 == number2 || number2 * number2 == number1)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

