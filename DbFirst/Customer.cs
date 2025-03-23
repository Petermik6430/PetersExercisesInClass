using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirst
{
    class Customer
    {

        public Customer(int customerID, string firstName, string lastName)
        {
            CustomerID = customerID;
            FirstName = firstName;
            LastName = lastName;
        }

        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return $"{CustomerID} {FirstName} {LastName}";
        }


    }
}
