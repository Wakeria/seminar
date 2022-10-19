// 1,Напишите программу, 
// 2.которая на входпринимает число 
// 3.и выдаёт его квадрат (число
// умноженное на само себя).

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine("введите целое число: ");  // переводит курсор на следующую сроку, а команда Write оставляет курсор на этой же строке

int number = Convert.ToInt32(Console.ReadLine());

// string str = Console.ReadLine();
// int num = Convert.ToInt32(str);

int square = number * number;
Console.WriteLine($"Квадрат числа {number} = {square}");