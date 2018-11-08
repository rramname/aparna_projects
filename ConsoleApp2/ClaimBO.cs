using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class ClaimBO
    {
        public void FindClaims(List<Claim> _claimList, string _claimStatus)
        {
            List<Claim> fClains = new List<Claim>();

           
            Console.WriteLine(String.Format("{0,-20}{1,-20}{2,-20}{3,-20}{4,-20}{5,-20}", "Policy ID", "Claim ID", "Claim Amount", "Claim Status", "Outcome Code", "Outcome Description"));

            foreach (Claim p in _claimList)
            {
                if (p.Status == _claimStatus)
                {
                    Console.WriteLine(p.ToString());
                }
            }

          

        }
    }
}
