using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5._5
{// Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN следующего вида:
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк");
            int n = (int)double.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов");
            int m = (int)double.Parse(Console.ReadLine());
            int[,] t = new int[n, m];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < m; j++)
                {
                    t[i, j] = random.Next(0, 2);

                    Console.Write(" {0,4} ", t[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        } 
    }
}
