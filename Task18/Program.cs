// Напишите программу,
// 1. которая по заданному номеру четверти,
// 2. показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти плоскости");
string quarter = Console.ReadLine();

string Quarter(string quarterXY)
{
    if (quarterXY == "1") return "x > 0 : y > 0";
    if (quarterXY == "2") return "x < 0 : y > 0";
    if (quarterXY == "3") return "x > 0 : y < 0";
    if (quarterXY == "4") return "x < 0 : y < 0";
return "некорректный ввод";
}

string xy = Quarter(quarter);
Console.WriteLine($"Диапазон координат для четверти => {quarter}: ");
Console.WriteLine(xy);