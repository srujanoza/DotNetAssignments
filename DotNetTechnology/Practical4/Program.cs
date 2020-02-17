<<<<<<< HEAD
﻿using System;
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
            Console.WriteLine("My name is " + name + "  and I am from " + country);
            Console.ReadLine();
        }

    }
}
=======
﻿using System;
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
>>>>>>> c7b60114b2c6531f43ec3c79f294dce3ebe52d59
