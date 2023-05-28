// Задача необязательная 1: на входе целое или вещественное число, надо удалить вторую цифру слева этого числа.

// 145 -> 15
// 1 -> нет
// 567,123 -> 57,123
                                           
namespace ConsoleApplication1   //НЕ РАБОТАЕТ! НЕ ПОЛУЧАЕТСЯ ЗАМЕНИТЬ "-2" на ","(запятую).
{
    class Program
    {
        static void Main(string[] args)
        {
 
            Console.Write("Введите набор чисел: ");
            string num = Console.ReadLine();

            int[] numbers = new int[num.Length];
 
            for (int i = 0; i < num.Length; i++)
            {
                if (IntForChar(num[i]) != -1)
                {
                    numbers[i] = IntForChar(num[i]);
                }
            }

            var numbersList = numbers.ToList();     //трансформировал в список и сам добавил для удаления 2 элемента, но что если это будет запятая?
            numbersList.Remove(3);                  //не то, удаляет определенную цифру, а не индекс.
            // int [] array = numbersList.ToArray();  //пытался изменить список на массив и найти элемент(-2) и заменить на запятую 
            // int x = 0;
            // for (int i = 0; i < array.Length; i++)
            //     {

            //     }
            foreach (var item in numbersList)
            {
                // var contains = numbersList.Contains(-2);
                // var contains = var.Parse ",";
                
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine("");//вывод на экран
 
            // Console.Read();
        }
 
        static int IntForChar(char ch)
        {
            switch (ch)
            {
                case '0': return 0;
                case '1': return 1;
                case '2': return 2;
                case '3': return 3;
                case '4': return 4;
                case '5': return 5;
                case '6': return 6;
                case '7': return 7;
                case '8': return 8;
                case '9': return 9;
                case ',': return -2;
                case '.': return -2;
            }
 
            return -1; // если это не число
        }
    }
}