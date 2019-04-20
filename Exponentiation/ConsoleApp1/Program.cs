using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Recursive Algorithms - Exponentiation");

            int answer = 1;

            Console.WriteLine("Please input the base number:");
            int.TryParse(Console.ReadLine(), out int baseNumber);

            Console.WriteLine("Please input the exp number:");
            int.TryParse(Console.ReadLine(), out int exp);

            for (int i = 1; i <= exp; i++)
                answer = answer * baseNumber;
            
            Console.WriteLine("Base = {0}, Exp = {1}", baseNumber, exp);
            Console.WriteLine("Answer = {0}", answer);
            Console.ReadLine();
        }
    }
}
