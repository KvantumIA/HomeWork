// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int funcAkkerman(int numN, int numM)
{
    if (numN == 0) 
        return numM + 1;
    else if (numM == 0)
        return funcAkkerman(numN-1, 1);
    return funcAkkerman(numN - 1, funcAkkerman(numN, numM - 1));
}



Console.Clear();
System.Console.Write("Введите целое число M: ");
int numM = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите целое число N: ");
int numN = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Функция Аккермана = {funcAkkerman(numM, numN)}");