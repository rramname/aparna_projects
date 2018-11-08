using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of Insurance companies");
            List<InsuranceCompany> iList = new List<InsuranceCompany>();
            int count = int.Parse(Console.ReadLine());
            for(int i = 0; i < count; i++)
            {
              
                    Console.WriteLine("Enter the Insurance company " + (i+1).ToString() + " details");
                string inp = Console.ReadLine();
                string[] inpt = inp.Split(',');

               
              
                Address a = new Address(inpt[1], inpt[2], inpt[3], inpt[4]);

              
                InsuranceCompany c = new InsuranceCompany(inpt[0], a);
                iList.Add(c);
            }

            Console.WriteLine("Enter the city");
            string city = Console.ReadLine();
            InsuranceCompanyBO bo = new InsuranceCompanyBO();
            bo.findCompaniesInCity(iList, city);
        }
    }
}
