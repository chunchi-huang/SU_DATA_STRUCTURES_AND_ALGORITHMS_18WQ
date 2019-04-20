using System;

namespace inversion
{
    class Inversion
    {
        static int count = 0;

        static void Main(string[] args)
        {
            int[] Array = { 1, 3, 5, 2, 4, 6, 7, 7, 9, 8 };

            Console.WriteLine("Count = {0}", CountInversions(Array));

            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write(Array[i]);
                Console.Write(", ");
            }
                
            Console.ReadLine();
        }

        static int CountInversions(int[] array)
        {
            if (array.Length > 1)
            {
                int m = array.Length / 2;
             
                int[] subArray1 = new int[m];
                int[] subArray2 = new int[array.Length - m];
                int[] newArray = new int[array.Length];

                Array.Copy(array, 0, subArray1, 0, subArray1.Length);
                Array.Copy(array, m, subArray2, 0, subArray2.Length);

                CountInversions(subArray1);
                CountInversions(subArray2);
                Helper(subArray1, subArray2, newArray, ref count);
                Array.Copy(newArray, array, array.Length);
            }

            return count;
        }

        static void Helper(int[] subArray1, int[] subArray2, int[] newArray, ref int count)
        {
            int i = 0, j = 0, k = 0;

            while (i < subArray1.Length && j < subArray2.Length)
            {
                if (subArray1[i] <= subArray2[j])
                    newArray[k] = subArray1[i++];
                else
                {
                    newArray[k] = subArray2[j++];

                    count = count + (subArray1.Length - i);
                }

                k++;
            }

            if (i == subArray1.Length)
                Array.Copy(subArray2, j, newArray, k, newArray.Length - k);
            else
                Array.Copy(subArray1, i, newArray, k, newArray.Length - k);
        }
    }
}
