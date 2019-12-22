using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab14_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 999999999, n;
            Console.WriteLine("Введите размер массива");
            n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0 && arr[i] < min)
                {
                    min = arr[i];
                }
            }
        }
    }
}
