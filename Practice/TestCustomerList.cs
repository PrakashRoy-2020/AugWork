using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPrac
{
    class Customer
    {
        public int Custid { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public double Balance { get; set; }
    }
    class TestCustomerList
    {
        static void Main()
        {
            List<Customer> obj = new List<Customer>() { 
                new Customer{Name="prakash",City="Kolkata"},
                new Customer{Name="roy",City="pune"},
            };
            Console.WriteLine();
        }
    }
}
