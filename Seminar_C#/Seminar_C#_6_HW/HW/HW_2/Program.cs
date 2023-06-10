// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double[] Point(int b1, int k1, int b2, int k2)
{
    double [] array = new double[2];
    double k3 = 0;
    double b3 = 0;

    k3 = k1-k2;
    b3 = b2-b1;
    array[0] = b3/k3; // находим координаты x
    array[1] = k1 * array[0] + b1; // находим координаты y
    return array;
}



Console.Clear();
System.Console.Write("Введите число b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

double[] array2 = Point(b1, k1, b2, k2);
System.Console.WriteLine();
System.Console.Write($"Точка пересечения двух прямых x = {array2[0]}, y = {array2[1]}");