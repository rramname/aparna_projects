using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_1_CC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Format("{0, -15}{1}", "Policy Name", "Premium"));
            List<Policy> p = new List<Policy>();
            PolicyBO b = new PolicyBO();
            p = b.FindMaxPremium();
            foreach(Policy p1 in p)
            {
                Console.WriteLine(String.Format("{0, -15}{1}", p1.Name, p1.Premium.ToString("f2")));
            }
        }
    }
}
