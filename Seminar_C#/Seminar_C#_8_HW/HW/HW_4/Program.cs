// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


void FillArray(int[,,] array, int[] RandomOneArray)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int z = 0; z < array.GetLength(2); z++)
                {
                    array[i,j,z] = RandomOneArray[count];
                    count ++;
                }
}

void RandomArray(int[] RandomOneArray)
{
    int num = 0;
    RandomOneArray[0] = new Random().Next(10,100);
    for (int i = 0; i < RandomOneArray.Length; i++)
    {
        num = new Random().Next(10,100);
        if (RandomOneArray.Contains(num))
            i--;
        else RandomOneArray[i] = num;
    }
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int z = 0; z < array.GetLength(2); z++)
            {
                Console.WriteLine($"{array[i,j,z],3} ({i},{j},{z})");
            }
            System.Console.WriteLine();
}



Console.Clear();
System.Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов в глубину: ");
int deep = Convert.ToInt32(Console.ReadLine());
int[,,] array = new int [rows, cols, deep];
int[] RandomOneArray = new int[rows*cols*deep];

RandomArray(RandomOneArray);

FillArray(array, RandomOneArray);
PrintArray(array);