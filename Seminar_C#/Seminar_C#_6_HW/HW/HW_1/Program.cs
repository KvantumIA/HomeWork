// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int[] ReadArr(int[] Arr)
{
    for (int i = 0; i < Arr.Length; i++)
    {
        System.Console.Write($"Введите число {i+1}: ");
        Arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    System.Console.WriteLine();
    return Arr;
}


void PrintArray(int[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item} ");
    }
    System.Console.WriteLine();
}


void PlusCount (int[] Arr)
{
    int count = 0;
    for (int i = 0; i < Arr.Length; i++)
    {
        if (Arr[i]>0)
            count++;
    }
    System.Console.WriteLine($"Количество положительных чисел равно: {count}");
}




Console.Clear();
System.Console.Write("Введите количество чисел: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] Arr = new int[num];
Arr = ReadArr(Arr);
PlusCount(Arr);