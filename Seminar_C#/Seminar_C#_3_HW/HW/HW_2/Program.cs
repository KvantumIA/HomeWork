// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.Clear();
System.Console.Write("Введите координаты точки А X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты точки А Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты точки А Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты точки В X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты точки В Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты точки В Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double CheckLength(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double r1= Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2));  
    return r1;
}


Console.WriteLine(CheckLength(x1, x2, y1, y2, z1, z2));