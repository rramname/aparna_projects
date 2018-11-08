using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PolicyBO
    {
        public List<Policy> FindPolicies(List<Policy> policyList, string _agentId)
        {
            List<Policy> filteredPolicyList = new List<Policy>();
            List<Agent> agents = new List<Agent>();
            
           
            Console.WriteLine(String.Format("{0,-20}{1,-20}{2,-20}{3,-20}{4,-20}", "Agent ID", "Agent Name", "Policy ID", "Policy Name", "Premium Payable"));

            foreach(Policy p in policyList)
            {
                if (p._agent.AgentID == _agentId)
                {
                    filteredPolicyList.Add(p);
                }
            }
            return filteredPolicyList;



        }
    }
}
