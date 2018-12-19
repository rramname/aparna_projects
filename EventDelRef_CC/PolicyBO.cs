using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDelRef_CC
{
    public static class PolicyBO
    {
   
        public static List<Policy> ListPoliciesByAgent(List<Policy> policyList, String name)
        {


            return policyList.Where(p => p.Agent.Name == name).ToList();


        }

        public static List<Policy> ListPoliciesByType(List<Policy> policyList, String type)
        {

            return policyList.Where(p => p.InsuranceType.Type == type).ToList();
            //return policies;
        }
    }
}
