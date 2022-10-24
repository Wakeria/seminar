//  Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.




Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

void SquareTable(int num)
{
    if (num > 0)
    {
        for (int i = 1; i <= num; i++)
        {
            Console.WriteLine($"|{i,4} | {i * i,4}|");
        }
    }
    else
    {
        Console.WriteLine("Введите значение больше 0");
    }
}

SquareTable(n);





// Console.Write("Введите число N: ");
// int num = Convert.ToInt32(Console.ReadLine());

// void TablPrint(int mnum)
// {
//     int count = 1;
//     while (mnum >= count)
//     {
//         Console.WriteLine($"{count} -> {count * count}");
//         count++;
//     }
// }


// if (num > 0)
// {
//     TablPrint(num);
// }
// else
// {
//     Console.WriteLine("Введите натуральное число!");
// }