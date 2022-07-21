using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using LanguageExt;

namespace ranec
{
    class Program
    {
        static long max, count;
        static long[] vah;
        static void Main(string[] args)
        {
            max = 16;
            Console.WriteLine("Введите count ");
            count = long.Parse(Console.ReadLine());
            vah = new long[count];
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Введите вес {0}-го блина ",i+1);

                vah[i] = Convert.ToInt32(Console.ReadLine());
            }
            long d = bag(vah, max);
            Console.WriteLine(d);
            Console.ReadLine();
        }

        static long bag(long[] vaha, long _max)
        {
            long n = vaha.Length;
            long[,] pl = new long[_max + 1, n + 1];
            for (int j = 1; j <= n; j++)
            {
                for (int i = 1; i <= _max; i++)
                {
                    if (vaha[j - 1] <= i)
                    {
                        pl[i, j] = Math.Max(pl[i, j - 1], pl[i - vaha[j - 1], j - 1]);
                    }
                }
            }
            return pl[_max, n];
            // Не работает, как надо, необходимо добавить в отличие
            // от задачи о рюкзаке сочетание двух блинов, а не нескольких предметов.
        }
    }
}