// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int Factorial(int num1, int num2)
{
    int result = 1;
    for (int i = 1; i<=num2; i++)
    {
        result = num1 * result;
    }
    return result;
}


Console.Clear();
System.Console.Write("Введите любое целое число A: ");
int num1 = Math.Abs(Convert.ToInt32 (Console.ReadLine()));
System.Console.Write("Введите любое целое число В: ");
int num2 = Math.Abs(Convert.ToInt32 (Console.ReadLine()));

System.Console.WriteLine($"Факториал числа А {num1} возведенный в степень {num2} равняется: {Factorial(num1, num2)}");