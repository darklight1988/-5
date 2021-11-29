using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5
{ // Формирование одномерного массива из 7 элементов. Заполнить массив числами, вводимыми с клавиатуры, определить среднее арифмитическое элекментов.
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[7];

            double Sred = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введите {0} число массива", i+1);
                
                array[i] = (int) double.Parse(Console.ReadLine());
                Sred = Sred + array[i];
               
            }
            double S = Sred / array.Length;

            Console.WriteLine("Массив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" " + array[i]);
            }
            
            Console.WriteLine();
            Console.WriteLine("Среднее арифмитическое {0} ",S);
            
            Console.ReadKey();
        }
    }
}
