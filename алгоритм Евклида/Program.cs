using System;

namespace алгоритм_Евклида
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Дана последовательность из N целых чисел и число K. 
            Необходимо сдвинуть всю последовательность (сдвиг - циклический) на |K| элементов вправо, если K – положительное 
            и влево, если отрицательное.
            */
            Console.WriteLine("Введите кол-во элементов массива:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите k (отрицательное или положительное число):");
            int k = Convert.ToInt32(Console.ReadLine());
            // Заполнение массива
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = new Random().Next(10);
            }
            
        }
    }
}
