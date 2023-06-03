// Задача 38: Задайте массив вещественных случайных чисел. Найдите разницу между максимальным и минимальным элементов массива.


void FillArray(double[] array)
{
    Random rand = new Random();
    for(int i = 0; i < array.Length; i++) 
    {
        array[i] = Math.Round((rand.NextDouble() * 99), 5);
    }
}


void PrintArray(double[] array)
{
    foreach(var item in array)
    {
        System.Console.Write($"{item} ");
    }
    System.Console.WriteLine();
}


double DifferenceArray(double[] array)
{
    double Difference = 0;
    double Max = array[0];
    double Min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < Min)
            Min = array[i];
        else if (array[i] > Max)
            Max = array[i];
    }
    Difference = Max - Min;
    return Math.Round(Difference, 5);
}




Console.Clear();
System.Console.Write("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];

FillArray(array);
System.Console.Write("Массив: ");
PrintArray(array);
System.Console.WriteLine($"Разница между максимальным и минимальным элементом равна: {DifferenceArray(array)}");