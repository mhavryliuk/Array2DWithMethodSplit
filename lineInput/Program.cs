using System;

// Пример использования метода Split для ввода двумерного массива не поэлементно, а построчно.
// Если строка отделена с известным набором символов, можно использовать Split(Char[]) метод, чтобы разделить подстроки.

namespace lineInput
{
    class Program
    {
        static void Print(int[][] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                foreach (int x in mas[i])
                {
                    Console.Write("{0} ", x);
                }
                Console.WriteLine();
            }
        }

        static void Main()
        {
            int[][] MyArray;
            Console.Write("Введите количество строк: ");
            int n = int.Parse(Console.ReadLine());
            MyArray = new int[n][];

            for (int i = 0; i < MyArray.Length; i++)
            {
                Console.Write("Введите элементы {0} строки: ", i);
                string line = Console.ReadLine();
                char[] div = { ' ', ',', '.' }; // Разделители элементов
                string[] mas = line.Split(div, StringSplitOptions.RemoveEmptyEntries); // Игнорирование пустых строк при разделении строк на слова
                MyArray[i] = new int[mas.Length];

                for (int j = 0; j < MyArray[i].Length; j++)
                {
                    MyArray[i][j] = int.Parse(mas[j]);
                }
            }

            Console.WriteLine("Введен массив:");
            Print(MyArray);

            Console.ReadLine();
        }
    }
}