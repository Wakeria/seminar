// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


Console.WriteLine("введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num2 > 0)
{
    int DegreeNumbers(int number1, int number2)
    {
        int sum = 1;
        for (int i = 1; i <= number2; i++)
        {

            sum *= number1;

        }
        return sum;
    }
    int degreeNumbers = DegreeNumbers(num1, num2);
    Console.WriteLine($"{num1},{num2} -> {degreeNumbers}");
}
else
{
    Console.WriteLine("второе число должно быть больше 0");
}