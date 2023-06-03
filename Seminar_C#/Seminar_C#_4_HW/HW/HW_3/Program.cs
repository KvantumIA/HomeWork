// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

void PrintArray (int[] myArray)
{
    foreach (var item in myArray)
    {
        System.Console.Write($"{item}, ");
    }
    System.Console.WriteLine();
}




Console.Clear();
int [] myArray = new int [8];

for (int i = 0; i<myArray.Length; i++)
{
    System.Console.Write($"Введите элемент массива под индексом {i}: ");
    myArray[i] = int.Parse(Console.ReadLine());
}
System.Console.WriteLine();
System.Console.Write("Вывод массива: ");
PrintArray(myArray);