// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


string sqrInline (double num)
{
    double count = 1;
    double sqr;
    string result = "";

    while (count <= num)
    {
        sqr = Math.Pow(count, 3);
        result = result + " " + sqr.ToString();
        count++;
    }
    return result;
}

Console.Clear();
System.Console.WriteLine("Введите целое число: ");
double num = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(sqrInline(num));