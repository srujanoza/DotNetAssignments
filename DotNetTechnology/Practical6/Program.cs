using System;

namespace Practical6
{
    class Program
    {
        static void Main(string[] args)
        {

            String number = Console.ReadLine();
            if (number.Length == 1)
            {
                Console.WriteLine(Digit.onedigit(Int32.Parse(number)));
            }
            else if (number.Length == 2)
            {
                Console.WriteLine(Digit.twodigit(Int32.Parse(number)));
            }
            else if (number.Length == 3)
            {
                Console.WriteLine(Digit.threedigit(Int32.Parse(number)));
            }
            else if (number.Length == 4)
            {
                Console.WriteLine(Digit.fourdigit(Int32.Parse(number)));
            }
            else if (number.Length == 5)
            {
                Console.WriteLine(Digit.fivedigit(Int32.Parse(number)));
            }
            else if (number.Length == 6)
            {
                Console.WriteLine(Digit.sixdigit(Int32.Parse(number)));
            }
            else
            {
                Console.WriteLine("Enter Number Only");
            }
            Console.WriteLine("Press Enter For Exit...");
            Console.ReadLine();
        }
    }
}