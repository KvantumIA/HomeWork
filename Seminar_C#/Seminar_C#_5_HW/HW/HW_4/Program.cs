// Задача HARD STAT необязательная: Задайте массив случайных целых чисел. Найдите максимальный элемент и его индекс, 
// минимальный элемент и его индекс, среднее арифметическое всех элементов. 
// Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями. 
// Найти медианное значение первоначалального массива , возможно придется кое-что для этого дополнительно выполнить.


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


void MaxAndIndexArray(int[] array, int[] MaxMinIndexDiffArray)
{
    int Summa = 0;
    int IndexMax = 0;
    int IndexMin = 0;
    int Max = array[0];
    int Min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < Min)
        {
            Min = array[i];
            IndexMin = i;
        }
        else if (array[i] > Max)
        {
            Max = array[i];
            IndexMax = i;
        }
        Summa = Summa + array[i];
    }
    
    Summa = Summa / array.Length;

    for (int i = 0; i < MaxMinIndexDiffArray.Length; i++)
    {
        if (i==0)
            MaxMinIndexDiffArray[i] = IndexMax;
        else if (i==1)
            MaxMinIndexDiffArray[i] = Max;
        else if (i==2)
            MaxMinIndexDiffArray[i] = IndexMin;
        else if (i==3)
            MaxMinIndexDiffArray[i] = Min;
        else if (i==4)
            MaxMinIndexDiffArray[i] = Summa;
    }
}


void SortArray(int[] array)
{
    int Min;
    for (int i = 0; i < array.Length; i++)
    {
        Min = i;
        for (int z = i; z < array.Length; z++)
        {
            if (array[z] < array[Min])
            {
                Min = z;
            }
        }
        if (array[Min] == array[i]) continue;
        int temp = array[i];
        array[i] = array[Min];
        array[Min] = temp;
    }
}


int MedianaArray(int[] array)
{
    int Mediana = 0;
    if (array.Length%2 == 1)
        Mediana = array[array.Length/2];
    else
    {
        for (int i = 0; i <= array.Length/2; i++)
        {
            Mediana = array[array.Length/2] + array[array.Length/2-1];
        }
    }
    return Mediana;
}




Console.Clear();
System.Console.Write("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int[] MaxMinIndexDiffArray = new int[5];

FillArray(array);
System.Console.Write("Массив: ");
PrintArray(array);
MaxAndIndexArray(array, MaxMinIndexDiffArray);
System.Console.WriteLine();

System.Console.WriteLine($"Индекс максимального элемента = {MaxMinIndexDiffArray[0]}");
System.Console.WriteLine($"Максимальный элемент = {MaxMinIndexDiffArray[1]}");
System.Console.WriteLine($"Индекс минимального элемента = {MaxMinIndexDiffArray[2]}");
System.Console.WriteLine($"Минимальный элемент = {MaxMinIndexDiffArray[3]}");
System.Console.WriteLine($"Среднее арифметическое всех элементов = {MaxMinIndexDiffArray[4]}");
System.Console.WriteLine();

SortArray(array);
System.Console.Write("Отсортированный массив: ");
PrintArray(array);

System.Console.WriteLine($"Медианное значение первоначального массива = {MedianaArray(array)}");