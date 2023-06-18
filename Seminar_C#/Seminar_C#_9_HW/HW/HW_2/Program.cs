// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int GetNumbersRec(int numStop, int numStart)
{
    if (numStop==numStart)  return (numStop);
    return GetNumbersRec(numStop - 1, numStart) + numStop;
}




Console.Clear();
System.Console.WriteLine("Введите целое число начало: ");
int numStart = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите целое число конец: ");
int numStop = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Сумма натуральных чисел от {numStart} до {numStop} равна {GetNumbersRec(numStop, numStart)}");