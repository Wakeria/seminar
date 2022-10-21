
// Напишите программу,
// 1.  которая выводит случайное число из отрезка [10, 99] 
// 2. и показывает наибольшую цифру числа.

// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 => {number}");

// int firstDigit = number / 10; //   78/10 = 7
// int secondDigit = number % 10; //  78 % 10  = 8

// if (firstDigit > secondDigit)
// {
//     System.Console.WriteLine($"Наибольшая цифра числа равна {firstDigit}");
// }
// else
// {
//     System.Console.WriteLine($"Наибольшая цифра числа равна {secondDigit}");
// }


// условный оператор

// int result = default;
// if (firstDigit > secondDigit) result = firstDigit;
// else result = secondDigit;
// System.Console.WriteLine($"Наибольшая цифра числа равна {result}");

// //тернарный оператор 1

// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;  // ? - тогда     : - иначе
// System.Console.WriteLine($"Наибольшая цифра числа равна {maxDigit}");

// // тернарный оператор 2

// System.Console.Write($"Наибольшая цифра числа {number} равна ");
// System.Console.WriteLine(firstDigit > secondDigit ? firstDigit : secondDigit);



int MaxDigit(int num)
{
    int firstDigit = num / 10; //   78/10 = 7
    int secondDigit = num % 10; //  78 % 10  = 8
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int maxDigit = MaxDigit(number);
System.Console.WriteLine($"Наибольшая цифра числа равна {maxDigit}");