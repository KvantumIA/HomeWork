// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int Kol(int num)
{
    int count = 0;
    if (num == 0) return 1;
    while (num >= 1)
    {
         num=num/10;
         count++;
    }
    return count;
}


int SummaArray(int[] myArray)
{
    int SummaArray = 0;
    for (int i = 0; i<myArray.Length; i++)
    {
        SummaArray = SummaArray + myArray[i];
    }
    return SummaArray;
}




Console.Clear();
System.Console.Write("Введите любое целое число: ");
int num = Math.Abs(Convert.ToInt32 (Console.ReadLine()));
int num3 = num;

int[] myArray = new int[Kol(num)];

for (int i = 0; i<myArray.Length; i++)
    {
        myArray[i] = num%10;
        num = num/10;
    }

System.Console.WriteLine($"Сумма сложения цифр числа {num3} равняется: {SummaArray(myArray)}");