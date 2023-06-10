// Задача НЕГАФИБОНАЧЧИ необязательная. Задайте число. Составьте массив чисел НегаФибоначчи, в том числе для отрицательных индексов.

// Пример:

// для k = 9 массив будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]


int[] Fibonacci(int num)
{
    int[] Fibon = new int[num];
    Fibon[0] = 0;
    Fibon[1] = 1;
    for (int i = 2; i < num; i++)
    {
        Fibon[i] = Fibon[i-1]+Fibon[i-2];
    }
    return Fibon;
}


int[] NegaFibonacci(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i%2 == 0)
            array[i] *= -1;
    }
    for (int i=0;i<array.Length/2;i++)
    {
        (array[array.Length-1-i],array[i]) = (array[i], array[array.Length-1-i] );
    }
    return array;
}


void PrintArray(int[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item}, ");
    }
    System.Console.WriteLine();
}


int[] SumArray(int[]NegaArray, int[] array2)
{
    int size = array2.Length+NegaArray.Length-1;
    int[] SummaArr = new int [size];
    for (int i = 0; i < array2.Length; i++)
    {
            SummaArr[i] = NegaArray[i];
    }
    int count = 0;
    for (int i = array2.Length-1; i < size; i++)
    {
            SummaArr[i] = array2[count];
            count++;
    }
    return SummaArr;
}




Console.Clear();
System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = Fibonacci(num);
int[] array2 = Fibonacci(num);

int[] NegaArray = NegaFibonacci(array);

System.Console.WriteLine();
int[] Summa = SumArray(NegaArray, array2);
System.Console.Write("Негафибоначчи: ");
PrintArray(Summa);