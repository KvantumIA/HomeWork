// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите номер дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num<1)
{
    System.Console.WriteLine("Вы ввели неправильный номер дня недели.");
}
else if (num<6)
{
    System.Console.WriteLine("Выходной: Нет");
}
else if (num<8)
{
    System.Console.WriteLine("Выходной: Да");
}
else
    System.Console.WriteLine("Вы ввели неправильный номер дня недели.");


// switch (num)   //Первый вариант решения.
//     {
//         case 1:
//             System.Console.WriteLine("Нет");
//             break;
//         case 2:
//             System.Console.WriteLine("Нет");
//             break;
//         case 3:
//             System.Console.WriteLine("Нет");
//             break;
//         case 4:
//             System.Console.WriteLine("Нет");
//             break;
//         case 5:
//             System.Console.WriteLine("Нет");
//             break;
//         case 6:
//             System.Console.WriteLine("Да");
//             break;
//         case 7:
//             System.Console.WriteLine("Да");
//             break;
//     }

