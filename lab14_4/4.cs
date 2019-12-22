using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab14_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, n;
            Console.WriteLine("Введите размер массива");
            n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            if (arr[0] > arr[1]) a = arr[0];
             for (int i = 1; i < n; i++)
            {
                if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                {
                    a = arr[i];
                }
                Console.WriteLine("Последний локальный максимум: {0}", a);
            }
        }
    }
}
