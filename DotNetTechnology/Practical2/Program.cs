using System;

namespace Practical2
{
    class Program
    {
        static void Main(string[] args)
        {
            CarSalesMan csm = new CarSalesMan("Srujan", "Oza");
            csm.sell();
            RetailSalesMan rsm = new RetailSalesMan("Virat", "Kohli");
            rsm.sell();
            Console.Read();
        }
    }
}
