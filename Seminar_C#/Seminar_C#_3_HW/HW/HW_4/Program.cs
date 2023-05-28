// Задача 21 - HARD необязательная

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве. Сначала задается N с клавиатуры, 
// потом задаются координаты точек.


double CheckLength(int[] KoordA, int[] KoordB)
{
    int x1 = 0;
    int x2 = 0;
    double result = 0;
    double r2 = 0;
    for (int i = 0; i<KoordA.Length; i++)
    {
        x1 = KoordA[i];
        x2 = KoordB[i];
        double r1 = Math.Pow((x2-x1),2);
        r2 = r2 + r1;
    }  
    result = Math.Sqrt(r2);
    return result;
}




Console.Clear();
System.Console.Write("Введите размерность: ");
int n = int.Parse(Console.ReadLine());

int[] KoordA = new int[n];
int[] KoordB = new int[n];

for (int i = 0; i<KoordA.Length; i++)
{
    System.Console.Write($"Введите координаты точки А{i}: ");
    KoordA[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i<KoordA.Length; i++)
{
    System.Console.Write($"Введите координаты точки В{i}: ");
    KoordB[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine(CheckLength(KoordA, KoordB));