using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minmax
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = {12, 4, 32, 76, 34, 77, 24, 12};
            int min = 0, max = 0;

            Minmax(Array, ref min, ref max, 0, Array.Length-1);
            Console.WriteLine();

            BruteMinmax(Array);
            Console.ReadLine();
        }
        
        static void BruteMinmax(int[] array)
        {
            int minval = array[0], maxval = array[0];
            int minpos = 0, maxpos = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxval)
                {
                    maxval = array[i];
                    maxpos = i;

                    Console.WriteLine("Brute: maxval = {0}, maxpos = {1}", maxval, maxpos);
                }

                if (array[i] < minval)
                {
                    minval = array[i];
                    minpos = i;
                    Console.WriteLine("Brute: minval = {0}, minpos = {1}", minval, minpos);
                }
            }
        }

        static void Minmax(int[] array, ref int min, ref int max, int l, int r)
        {
            int m = 0; 
            int min1 = 0, max1 = 0;

            if (l == r)
            {
                min = array[l];
                max = array[l];

                Console.WriteLine("r = l = {0}", r);
            }
            else if ((r - l) == 1)
            {
                Console.Write("r-l = 1, ");
                Console.WriteLine("r = {0}, l = {1}", r, l);

                if (array[l] <= array[r])
                {
                    min = array[l];
                    max = array[r];
                }
                else
                {
                    min = array[r];
                    max = array[l];
                }
            }
            else 
            {
                Console.WriteLine("r-l > 1");
                m = (l + r) / 2;
                Minmax(array, ref min, ref max, l, m);
                Console.WriteLine("Left side: left = {0}, right = {1}, min = {2}, max = {3}", l, m, min, max);
                Minmax(array, ref min1, ref max1, m + 1, r);
                Console.WriteLine("Right side: left = {0}, right = {1}, min1 = {2}, max1 = {3}", m+1, r, min1, max1);

                if (max1 > max)
                    max = max1;
                if (min1 < min)
                    min = min1;                
            }

            Console.WriteLine("min = {0}, max = {1}\n", min, max);
        }
    }
}
