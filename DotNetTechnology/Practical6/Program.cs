using System;
using System.Collections.Generic;

namespace Practical6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number = 25;
            void spell(number);

            static void spell (int number)
            {

            }

            Stack<String> stack = new Stack<String>();
            while(number > 0)
            {
                int i = number % 10;
                switch(i)
                {
                    case 0: 
                        stack.Push("Zero");
                        break;
                    case 1:
                        stack.Push("One");
                        break;
                    case 2:
                        stack.Push("Two");
                        break;
                    case 3:
                        stack.Push("Three");
                        break;
                    case 4:
                        stack.Push("Four");
                        break;
                    case 5:
                        stack.Push("Five");
                        break;
                    case 6:
                        stack.Push("Six");
                        break;
                    case 7:
                        stack.Push("Seven");
                        break;
                    case 8:
                        stack.Push("Eight");
                        break;
                    case 9:
                        stack.Push("Nine");
                        break;
                    default: Console.WriteLine("Invalid");
                        break;

                }
                int j = number / 10;
                number = j;
            }
            while(stack.Count > 0)
            {
                 
                Console.Write(stack.Peek());
            }
            
        }
    }
}
