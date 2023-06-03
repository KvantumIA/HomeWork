// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
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


int EvenCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0)
            count++;
    }
    return count;
}



Console.Clear();
System.Console.Write("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

FillArray(array);
System.Console.Write("Массив: ");
PrintArray(array);
System.Console.Write($"Количество четных чисел в массиве: {EvenCount(array)}");