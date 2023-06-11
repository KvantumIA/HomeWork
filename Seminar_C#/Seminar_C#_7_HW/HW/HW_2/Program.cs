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
            array[i,j] = new Random().Next(1,10);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j],3}  ");
        System.Console.WriteLine();
    }
}

void PrintPosition(int[] Position)
{
    // int count = 0;
    for (int i = 0; i < Position.Length; i++)
    {
        if (i == 0) System.Console.Write($"{Position[i]}:");
        else if (i%2 == 1)
            {
                System.Console.Write($"{Position[i]};  ");
            }
        else if (i%2 == 0)
            System.Console.Write($"{Position[i]}:");
    }

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

int FindCount(int[,] array, int num)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (num == array[i,j])
                {
                    count = count + 2;
                }
            }
        }
    return count;
}

int[] FindPosition(int[,] array, int num, int count)
{
    int[] Position = new int[count];
    int count2 = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        {
        for (int j = 0; j < array.GetLength(1); j++)
            if (num == array[i,j])
            {
                Position[count2] = i;
                Position[count2+1] = j;
                count2 = count2 + 2;
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
int count = FindCount(array, num);
int[] Position = FindPosition(array, num, count);
System.Console.WriteLine();
if (Find(array, num) == true)
    {
        System.Console.Write($"Такое число в массиве: есть. Его позиция = ");
        PrintPosition(Position);
    }
else
    System.Console.WriteLine($"Такого числа в массиве: нет");