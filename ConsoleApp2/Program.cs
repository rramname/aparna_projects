using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Y";
            Console.WriteLine("Enter Claim Details");
            List<Claim> claims = new List<Claim>();
            do
            {
               
                string strClaim = Console.ReadLine();

                string[] vals = strClaim.Split(',');
               


                ClaimOutcome outc = new ClaimOutcome(vals[3], vals[4]);
              
             
            

                if (vals.Length > 5)
                {
                    Claim c = new Claim(vals[1], vals[0], vals[3], vals[4], Double.Parse(vals[2]), vals[5]);
                    claims.Add(c);
                }
                else
                {
                    Claim c = new Claim(vals[1], vals[0], vals[3], vals[4], Double.Parse(vals[2]));
                    claims.Add(c);
                }
              

                Console.WriteLine("Enter 'Y' to add another detail");
                str = Console.ReadLine();

            } while (str == "Y");

            Console.WriteLine("Enter Claim Status");
            string st=Console.ReadLine();

            ClaimBO bo = new ClaimBO();
            bo.FindClaims(claims, st);
            Console.ReadLine();
        }
    }
}
