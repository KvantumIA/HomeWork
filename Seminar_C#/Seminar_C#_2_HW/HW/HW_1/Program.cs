// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите целое трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

double d = Math.Log(num, 10);
int razryad = Convert.ToInt32(d);

if (razryad==3)
    {
        int num1 = num%100;
        int num2 = num1/10;
        System.Console.WriteLine(num2);
    }
else
    System.Console.WriteLine("Вы ввели не трехзначное число!");
