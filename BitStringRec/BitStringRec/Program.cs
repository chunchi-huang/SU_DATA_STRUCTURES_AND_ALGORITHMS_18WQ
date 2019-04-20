using System;

namespace BitStringRec
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the n number:");
            int.TryParse(Console.ReadLine(), out int n);
            Console.WriteLine();

            int[] array = new int[n];
            BitStringRec(array, n);
            Console.ReadLine();
        }

        public static void BitStringRec(int[] array, int n)
        {
            if (n == 0)
            {
                for (int i = 0; i < array.Length; i++)
                    Console.Write("{0},", array[i]);
       
                Console.WriteLine();               
            }
            else
            {
                array[n - 1] = 0;
                BitStringRec(array, n - 1);
                array[n - 1] = 1;
                BitStringRec(array, n - 1);
            }
        }
    }
}
