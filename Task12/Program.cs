//  Напишите программу, 
//  1.которая будет принимать навход два числа и 
//  2. выводить, является ли второе число кратным первому. 
 
//  Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


Console.WriteLine("введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 % number2 == 0 )
Console.WriteLine("кратно");
else 
Console.WriteLine($" не кратно остаток {number1 % number2}");
