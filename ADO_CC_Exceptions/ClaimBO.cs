using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_CC_Exceptions
{
    public class ClaimBO
    {
        public bool AddClaim(string cNames, string cValues)
        {
            //fill your code
            Claim d = new CalimDAO();
            string[] cnames1 = cNames.Split(',');
            string[] vals = cValues.Split(',');
            d.AddClaim(cnames1[0], cnames1[1], cnames1[2], cnames1[3], vals[0], vals[1], vals[2], vals[3]);
            return true;
        }
    }
}
