// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,100);
    }
}


void PrintArray(int[] array)
{
    foreach(var item in array)
    {
        System.Console.Write($"{item} ");
    }
    System.Console.WriteLine();
}


int SummaArray(int[] array)
{
    int summa = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i%2 == 1)
            {
                summa = summa + array[i];
            }
    }
    return summa;
}



Console.Clear();
System.Console.Write("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

FillArray(array);
System.Console.Write("Массив: ");
PrintArray(array);
System.Console.WriteLine($"Сумма элементов стоящих на нечетных индексах: {SummaArray(array)}");