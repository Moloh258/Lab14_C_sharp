using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab14_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Введите размер массива: ");
            n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int k = arr[1] - arr[0];

            for (int i = 1; i < n && k != 0; i++)
            {
                if (k != arr[i] - arr[i - 1])
                {
                    k = 0;
                }
            }

            Console.WriteLine(k);
        }
    }
}
