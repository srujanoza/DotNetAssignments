using System;
using System.Text.RegularExpressions;
namespace Practical4
{
    class Program
    {
        static void Main(string[] args)
        {
            String name, country;
            do
            {
                Console.WriteLine("What is your name?");
                name = Console.ReadLine();
            } while (!Regex.IsMatch(name, "^[a-zA-Z]+$"));
            do
            {
                Console.WriteLine("What is your country name?");
                country = Console.ReadLine();
            } while (!Regex.IsMatch(country, "^[a-zA-Z]+$"));
            Console.WriteLine("My name is " + name + " and I am from " + country);
            Console.ReadLine();
        }

    }
}
