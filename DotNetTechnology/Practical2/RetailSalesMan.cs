using System;
using System.Collections.Generic;
using System.Text;

namespace Practical2
{
    public class RetailSalesMan: SalesMan
    {
       public RetailSalesMan(String firstName, String lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
       public void sell()
        {
            Console.WriteLine("Name:" + firstName + " " + lastName);
        }
    }
}
