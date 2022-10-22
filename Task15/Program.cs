
// Задача 15: Напишите программу,
//  которая принимает на вход цифру, обозначающую день недели,
//   и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 7 || number == 6) 
{
    Console.Write(" да, это выходной ");
}
else if (number < 0 || number > 7)
{
   Console.Write(" в неделе только 7 дней "); 
}
else if (number > 0 && number < 6)
{
    Console.WriteLine(" это будний день");
}