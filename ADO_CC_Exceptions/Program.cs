using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_CC_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            string cols=Console.ReadLine();
            string vals = Console.ReadLine();
            ClaimBO bo = new ClaimBO();
            try
            {
                bo.AddClaim(cols, vals);
                Console.WriteLine("Claim details inserted successfully.");

            }
            catch(Exception e)
            {
                Console.WriteLine("Invalid column name '" + e.Message + "'.");
            }
            
        }
    }
}
