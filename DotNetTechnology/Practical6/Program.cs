using System;
using System.Collections.Generic;

namespace Practical6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number;
            number = Console.Read();



            int i;
            Stack<String> stack = new Stack<String>();
            while(number > 0)
            {
                i = number % 10;
                
                switch (i)
                {
                    case 0:
                        stack.Push("zero");
                        break;
                    case 1:
                        stack.Push("one");
                        break;
                    case 2:
                        stack.Push("two");
                        break;
                    case 3:
                        stack.Push("three");
                        break;
                    case 4:
                        stack.Push("four");
                        break;
                    case 5:
                        stack.Push("five");
                        break;
                    case 6:
                        stack.Push("six");
                        break;
                    case 7:
                        stack.Push("seven");
                        break;
                    case 8:
                        stack.Push("eight");
                        break;
                    case 9:
                        stack.Push("nine");
                        break;
                    default:
                        Console.WriteLine("invalid");
                        break;

                }
                number /= 10;
            }
            while(stack.Count > 0)
            {
                 
                Console.Write(stack.Pop());
            }
            Console.ReadLine();
        }
    }
}
