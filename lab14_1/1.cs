using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace lab14_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //объявление
            int sum = 0;
            WriteLine("Введите размер массива");
            int n = ToInt32(ReadLine());
            int[] A = new int[n];
            WriteLine("Введите элементы массива");
            for(int i = 0; i < n; i++)
            {
                A[i] = ToInt32(ReadLine());
            }
            // K и L
            WriteLine("Введите целые числа K, L (1 <= K <= L <= N");
            int k = ToInt32(ReadLine());
            int l = ToInt32(ReadLine());
            //Сумма
            if (l > k && l < n)
            {
                for (int i = k - 1; i <= l - 1; i++)
                {
                    sum += A[i];
                }
                WriteLine("Среднее арифметическое равно: {0}", sum / l - k + 1);
            }
            else
            {
                WriteLine("Введены неверные данные");
            }
        }
    }
}
