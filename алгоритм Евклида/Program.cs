﻿using System;

namespace алгоритм_Евклида
{
    class Program
    {
        static void Main(string[] args)
        {
            // таблица умножения

            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
                Console.Write("\n");
            }
        }
    }
}
