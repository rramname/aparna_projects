using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_1_CC
{
    public class PolicyBO
    {
        public List<Policy> FindMaxPremium()
        {
            PolicyDAO dao = new PolicyDAO();
           return dao.FindMaxPremium();
        }

    }
}
