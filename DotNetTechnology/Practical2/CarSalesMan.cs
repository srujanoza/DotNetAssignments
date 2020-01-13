using System;
using System.Collections.Generic;
using System.Text;

namespace Practical2
{
   public  class CarSalesMan : SalesMan 
    {
       public CarSalesMan(String firstName, String lastName)
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
