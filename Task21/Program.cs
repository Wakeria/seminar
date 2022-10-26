// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите координаты точки A: ");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: ");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());


double Range(int x11, int y11, int z11, int x21, int y21, int z21)
{
 int rangeX = x11 - x21;
 int rangeY = y11 - y21;
 int rangeZ = z11 - z21;
 double rangeAB = Math.Sqrt(rangeX * rangeX + rangeY * rangeY + rangeZ * rangeZ);
 return rangeAB;
}

double result = Range(x1,y1,z1,x2,y2,z2);
Console.WriteLine ($"Расстояние между точками A ({x1},{y1},{z1}) и B ({x2},{y2},{z2}) равна: {Math.Round(result, 2, MidpointRounding.ToZero)}");