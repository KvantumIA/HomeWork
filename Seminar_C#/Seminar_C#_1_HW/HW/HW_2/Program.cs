// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число C: ");
int numC = Convert.ToInt32(Console.ReadLine());
int max = numA;
int sum = 0;

while (sum < 3)
    {
        if (max<numB)
            {
                max = numB;
                sum++;
            }
        else if (max<numC)
            {
                max = numC;
                sum++;
            }
        else
            sum++;
    }

System.Console.WriteLine("Наибольшее число: "+max);