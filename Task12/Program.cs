//  Напишите программу, 
//  1.которая будет принимать навход два числа и 
//  2. выводить, является ли второе число кратным первому. 

//  Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


// Console.WriteLine("введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// if (number1 % number2 == 0 )
// Console.WriteLine("кратно");
// else 
// Console.WriteLine($" не кратно остаток {number1 % number2}");




Console.WriteLine("введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int DivNum(int number1, int number2)
{
    int result = number1 % number2;
    return result;

}

int result = DivNum(num1, num2);
if (result > 0)
{
    Console.WriteLine($" не кратно, остаток {result}");
}
else
{
    Console.WriteLine("кратно");
}