using System;

namespace Practical1
{
    class Program
    {
        static void Main(string[] args)
        {
            pattern1();
            Console.WriteLine();
            pattern2();
            Console.WriteLine();
            pattern3();
            Console.ReadLine();
        }
        static void pattern1()
        {
            Console.WriteLine("Pattern1");
            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
            }
        }

        static void pattern2()
        {
            Console.WriteLine("Pattern2");
            for (int j = 0; j <= 5; j++)
            {
                for (int i = 0; i < j; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
            }
        }

        static void pattern3()
        {
            Console.WriteLine("Pattern3");
            for (int j = 5; j >=0; j--)
            {
                for (int i = j; i >=0; i--)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
