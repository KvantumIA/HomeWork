// Задача 26 HARD Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.
// 456 -> 3
// 0 -> 1
// 89,126 -> 5
// 0,001->4

// int DoubleToInt(decimal num)
// {
//     while(num%1 != 0)
//     {
//         num *= 10;
//     }
//     return Convert.ToInt32(num);
// }

// int CountDigitNumber(int num)
// {
//     if(num == 0) return 1;
//     int count = 0;
//     while (num != 0)
//     {
//         num /= 10;
//         count++;
//     }
//     return count;
// }




// Console.Clear();
// System.Console.WriteLine("Введите число: ");
// decimal num = Convert.ToDecimal(System.Console.ReadLine());

// int temp = 0;
// temp = DoubleToInt(num);

// System.Console.WriteLine($"Количество цифр: {CountDigitNumber(temp)}");




int DoubleToInt(decimal num)
{
    while(num%1 != 0)
    {
        num *= 10;
    }
    return Convert.ToInt32(num);
}

int CountDigitNumber(int num)
{
    if(num == 0) return 1;
    int count = 0;
    while (num != 0)
    {
        num /= 10;
        count++;
    }
    return count;
}



Console.Clear();
System.Console.WriteLine("Введите число: ");
decimal num = Convert.ToDecimal(System.Console.ReadLine());

int temp = 0;
temp = DoubleToInt(num);

System.Console.WriteLine(temp);

System.Console.WriteLine($"Количество цифр: {CountDigitNumber(temp)}");