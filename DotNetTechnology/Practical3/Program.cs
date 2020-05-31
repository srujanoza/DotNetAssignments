using System;
using System.Numerics;
namespace Practical3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            DecimalToHex(11);
            BinaryToDecimal(1010);
            DecimalToBinary(10);
            
           DecimalToOctal(9);
            
            Console.ReadLine();
        }

        private static void DecimalToOctal(int n)
        {
            int[] arr = new int[50];
            int i = 0;
            while (n > 0)
            {
                arr[i] =(n % 8);
                i += 1;
                n /= 8;

            }
            Console.WriteLine("Decimal To Octal");
            for (int j = i - 1; j >= 0; j--)
            {
                Console.Write(arr[j]);
            }
        }

        private static void DecimalToHex(int n)
        {
            char[] arr = new char[50];
            int i = 0;
            while(n>0)
            {
                arr[i] = (char)(n % 16);
                if(arr[i]>9)
                {
                    arr[i] = (char)(arr[i] + 55);
                }
                else
                {
                    arr[i] = (char)(arr[i] + 48);
                }
                i += 1;
                n /= 16;
                
            }
            Console.WriteLine("Decimal To Hex");
            for (int j = i-1;j>=0;j--)
            {
                Console.Write(arr[j]);
            }
            Console.WriteLine();
        }

        private static void DecimalToBinary (int n)
        {
            int[] ar = new int[50];
            int i = 0;
            while (n > 0)
            {
                ar[i] =( n % 2);
                i++;
                n /= 2;
            }
            Console.WriteLine("Decimal To Binary");
            for (; i >= 0; i--)
            {

                Console.Write(ar[i]);
            }

            Console.WriteLine();
        }

        private static void BinaryToDecimal(int n)
        {
            int temp,d=0, i=0;
            while (n > 0)
            {
                temp = (n % 10);
                d += (int)(temp * Math.Pow(2, i));

                n /= 10;
                i++;
            }
            Console.WriteLine("Binary To Decimal");
            Console.Write(d);
            Console.WriteLine();
        }
    }
}

﻿