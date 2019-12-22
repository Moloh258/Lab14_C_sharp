using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab14_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k = 0, b = 0;

            Console.Write("Введите размер массива: ");
            n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (arr[i] == arr[j] && i != j)
                    {
                        k = i;
                        b = j;
                        break;
                    }
                }
            }

            if (k > b)
            {
                Console.WriteLine("Номера одинаковых элементов {0} и {1}", b, k);
            }
            else { Console.WriteLine("Номера одинаковых элементов {0} и {1}", k, b); }
        }
    }
}
