// Напишите программу,
// 1. которая на вход принимает число
// 2. и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("yes");

}
else
{
   Console.WriteLine("no") ;
}