using System;

namespace алгоритм_Евклида
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*
            Дана последовательность из N целых чисел и число K.
            Необходимо сдвинуть всю последовательность (сдвиг - циклический) на |K| элементов вправо, если K – положительное
            и влево, если отрицательное.
            */
            Console.WriteLine("Введите кол-во элементов массива:");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine("Введеное число не должно быть равно нулю! Программа завершает работу!");
                return;
            }
            else
                n = Math.Abs(n); 
            Console.WriteLine("Введите k (отрицательное или положительное число):");
            int k = Convert.ToInt32(Console.ReadLine());
            // Заполнение массива
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
                array[i] = new Random().Next(10);
            Console.WriteLine();
            Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");
            // Cдвиг
            for (int j = 1; j <= Math.Abs(k); j++)
                if (k >= 0)
                    for (int i = n - 1; i > 0; i--)
                    {
                        int temp;
                        temp = array[i - 1];
                        array[i - 1] = array[i];
                        array[i] = temp;
                    }
                else
                    for (int i = 0; i < n - 1; i++)
                    {
                        int temp;
                        temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                    }
            Console.WriteLine("Конечный массив: [" + string.Join(", ", array) + "]");
        }
    }
}