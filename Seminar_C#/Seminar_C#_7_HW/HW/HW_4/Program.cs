// Задача HARD SORT необязательная. Считается за три обязательных
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.

// Например, задан массив:
// 1 4 7 2
// 5 9 10 3

// После сортировки
// 1 2 3 4
// 5 7 9 10



void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().Next(0,11);
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

int[] Sort(int[,] array)
{
    int[] array2 = new int[array.GetLength(0)*array.GetLength(1)];
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array2[count] = array[i,j];
            count++;
        }
    }
    return array2;
}

void SortArray (int [] array2)
{
    for (int i = 0; i < array2.Length-1; i++)
    {
        int imin = i;
        for (int j = i+1; j < array2.Length; j++)
        {
            if (array2[j]<array2[imin])
                imin = j;
        }
        int temp = array2[i];
        array2[i]=array2[imin];
        array2[imin]=temp;
    }
}

void FillSort(int[] array2, int[,] myArray)
{
    int count = 0;
    for (int i = 0; i < myArray.GetLength(0); i++)
        {
            for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    myArray[i,j] = array2[count];
                    count++;
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

int[] array2 = Sort(array);
System.Console.WriteLine();
SortArray(array2);

int[,] myArray = new int [rows, cols];
FillSort(array2, myArray);
System.Console.WriteLine("Отсортированный массив:");
PrintArray(myArray);