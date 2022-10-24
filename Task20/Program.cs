// апишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21


Console.WriteLine("Введите координату x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());

double Range(int x11, int y11, int x21, int y21)
{
 int rangeX = x11 - x21;
 int rangeY = y11 - y21;
 double rangeZ = Math.Sqrt(rangeX * rangeX + rangeY * rangeY);
 return rangeZ;
}

double result = Range(x1,y1,x2,y2);
Console.WriteLine ($"A ({x1},{y1}); B ({x2},{y2}) -> {Math.Round(result, 2, MidpointRounding.ToZero)}");





// Console.WriteLine("Введите координаты точки 1:");
// Console.Write("X: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Y: ");
// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координаты точки 2:");
// Console.Write("X: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Y: ");
// int y2 = Convert.ToInt32(Console.ReadLine());


// double OurLength(int mx1, int my1, int mx2, int my2)
// {
// return Math.Sqrt((mx2 - mx1) * (mx2 - mx1) + (my2 - my1) * (my2 - my1));
// }

// double d = OurLength(x1, y1, x2, y2);
// double res = Math.Round(d, 2, MidpointRounding.ToZero);

// Console.WriteLine($"Расстояние между точками равно {res}");