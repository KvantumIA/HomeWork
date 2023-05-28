// Задача 19 - HARD необязательная

// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, является ли оно палиндромом. Через строку нельзя решать само собой.


// Console.Clear();
System.Console.Write("Введите целое число любой разрядности: ");
int num = Convert.ToInt32(Console.ReadLine());

double d = Math.Log10(num);
double c = Math.Ceiling(d);
int razryad = Convert.ToInt32(c);

int[] numPalindrom = new int[razryad];

for (int i = 0; i<numPalindrom.Length; i++)
{
    numPalindrom[i] = num%10;
    num = num/10;
    // System.Console.WriteLine(num);
}

int count = 0;
for (int z = 0; z<numPalindrom.Length; z++)
{
    // System.Console.WriteLine(numPalindrom[z]);
    int index1 = numPalindrom[z];
    Index index2 = ^2;
    System.Console.WriteLine($"Index1: {index1}");
    System.Console.WriteLine($"Index2: {index2}");
    System.Console.WriteLine($"Индекс Z: {z}");
    if (index1 == numPalindrom[index2])
        {
            count++;
        }
    else
        continue;
}

if (count == razryad)
    System.Console.WriteLine("Это число является палиндромом");
else
    System.Console.WriteLine("Не является палиндромом");

// System.Console.WriteLine(razryad);
// System.Console.WriteLine(count);