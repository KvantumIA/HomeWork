// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().Next(1,15);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j],3}    ");
        System.Console.WriteLine();
        }
}

void PrintPosition(int[] Position)
{
    foreach (var item in Position)
        System.Console.Write($"{item}: ");
}

bool Find(int[,] array, int num)
{
    bool Find = false;
    for (int i = 0; i < array.GetLength(0); i++)
        {
        for (int j = 0; j < array.GetLength(1); j++)
            if (num == array[i,j])
                Find = true;
        }
    return Find;
}

int[] FindPosition(int[,] array, int num)
{
    int[] Position = new int[2];
    for (int i = 0; i < array.GetLength(0); i++)
        {
        for (int j = 0; j < array.GetLength(1); j++)
            if (num == array[i,j])
                {
                    Position[0] = i;
                    Position[1] = j;
                }
        }
    return Position;
}



Console.Clear();
System.Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число для поиска: ");
int num = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [rows, cols];
FillArray(array);
PrintArray(array);
int[] Position = FindPosition(array, num);

if (Find(array, num) == true)
    {
        System.Console.Write($"Такое число в массиве: есть. Его позиция = ");
        PrintPosition(Position);
    }
else
    System.Console.WriteLine($"Такого числа в массиве: нет");