﻿// задача 2 HARD необязательная. Считается за четыре обязательных ) то есть три этих и одна с будущего семинара
// Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры) , причем чтоб количество элементов было четное. Вывести на экран красивенько таблицей. Перемешать случайным образом элементы массива, причем чтобы каждый элемент гарантированно и только один раз переместился на другое место и выполнить перемешивание за m*n / 2 итераций. То есть если массив три на четыре, то надо выполнить за 6 итераций. И далее в конце опять вывести на экран как таблицу.
// например, на входе массив 2* 3
// 2 3 5
// 1 9 4
// первая итерация перемешивания - выбрали индексы 0,0 и 1,2 случайный образом, поменяли ячейки
// 4 3 5
// 1 9 2
// вторая итерация - индексы 0, 0 и 1,2 не трогаем, так как это уже перемещенные ячейки, выбираем случайным образом из оставшихся ячеек, выбрали ячейки 0, 1 и 0,2, поменяли значения
// 4 5 3
// 1 9 2
// третья итерация - теперь остались только ячейки 1,0 и 1,1, меняем их местами
// 4 5 3
// 9 1 2



void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().Next(-30,31);
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

void Sort(int[,] array, int cols)
{
    int rows1 = new Random().Next(0,cols);
    int cols1 = new Random().Next(0,cols);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

        }
    }
}

Console.Clear();
System.Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] array = new int [rows, cols];
FillArray(array);
PrintArray(array);