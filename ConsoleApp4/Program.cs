using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string csvData = File.ReadAllText("input.csv");
            string[] rows = csvData.Split('\n');
            List<Customer> customers = new List<Customer>();
            foreach (string row in rows)
            {
                if (!string.IsNullOrEmpty(row))
                {
                    string[] cols = row.Split(',');
                    Customer c = new Customer();
                    c.Name = cols[0];
                    c.LastName = cols[1];
                    c.ContactNumber = cols[2];
                    c.Email = cols[3];
                    customers.Add(c);
                }
            }

            Console.WriteLine("Enter the name to search");
            string str = Console.ReadLine();

            List<Customer> fCustomers = new List<Customer>();
            var listC = from c in customers where c.Name.Equals(str) || c.LastName.Equals(str) select c;
            Console.WriteLine(String.Format("{0,-20}{1,-20}{2,-20}{3,0}", "First name", "Last name", "Contact number", "Email"));
            //Console.WriteLine("First name          Last name           Contact number      Email");
            foreach (Customer c in listC)
            {
                //Console.WriteLine(c.Name+c.LastName+c.ContactNumber+c.Email);
                Console.WriteLine(String.Format("{0,-20}{1,-20}{2,-20}{3,0}", c.Name, c.LastName, c.ContactNumber, c.Email));
            }
        }
    }
}
