using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class InsuranceCompanyBO
    {
        public void findCompaniesInCity(List<InsuranceCompany> list, string city= "Mumbai")
        { 
            Console.WriteLine(String.Format("{0,-20}{1,-10}", "Name", "Address"));
            foreach (InsuranceCompany a in list)
            {
                if (a.Address.City.Equals(city))
                {
                    a.ToString();
                }
            }
        }
    }
}
