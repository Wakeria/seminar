// Напишите программу,
//  1. которая на вход принимает два числа 
//  2. и выдаёт, какое число большее, а какое меньшее

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.WriteLine("введите два числа: "); 

int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB) 
{
    Console.Write($" max = {numberA} ");
}
else if (numberB > numberA)
{
   Console.Write($" max = {numberB} "); 
}
else
{
    Console.WriteLine("числа равны");
}