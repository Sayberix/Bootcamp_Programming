using System;

namespace алгоритм_Евклида
{
    class Program
    {
        static void Main(string[] args)
        {
            // алгоритм Евклида
            int n = 140;
            int m = 175;
            int count = n * m;
            while(n != m)
            {
                if (n > m)
                    n -= m;
                else
                    m -= n;
                Console.WriteLine(n);
                Console.WriteLine(m);
                Console.WriteLine();
            }
            // НОК
            Console.WriteLine("НОК: " + count / m);
        }
    }
}
