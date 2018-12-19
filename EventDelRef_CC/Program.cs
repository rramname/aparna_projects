using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDelRef_CC
{
    class Program
    {
      
        delegate List<Policy> AgentPolicyList(List<Policy> policyList, string _agentName);
        delegate List<Policy> ListPoliciesByTypeDel(List<Policy> policyList, string _agentName);
        static void Main(string[] args)
        {
            List<Policy> _policyList = new List<Policy>();
            _policyList.Add(new Policy(2154, new InsuranceType(3158, "Life Insurance"), new Agent(154, "Jacob"), 25000));
            _policyList.Add(new Policy(3401, new InsuranceType(3548, "Health Insurance"), new Agent(251, "Daniel"), 30000));
            _policyList.Add(new Policy(2549, new InsuranceType(3154, "Vehicle Insurance"), new Agent(154, "Jacob"), 15000));
            _policyList.Add(new Policy(3504, new InsuranceType(3158, "Life Insurance"), new Agent(251, "Daniel"), 20000));
            _policyList.Add(new Policy(2501, new InsuranceType(3548, "Health Insurance"), new Agent(624, "Andrew"), 35000));
            _policyList.Add(new Policy(2509, new InsuranceType(3154, "Vehicle Insurance"), new Agent(624, "Andrew"), 27000));
            int i = int.Parse(Console.ReadLine());
            for (int j = 0; j < i; j++)
            {
                string[] str = Console.ReadLine().Split(',');
                InsuranceType ins = new InsuranceType(int.Parse(str[1]), str[2]);
                Agent ag = new Agent(int.Parse(str[3]), str[4]);
                Policy p = new Policy(int.Parse(str[0]), new InsuranceType(int.Parse(str[1]), str[2]), new Agent(int.Parse(str[3]), str[4]), double.Parse(str[5]));
                _policyList.Add(p);
            }
            string agName = Console.ReadLine();
            //PolicyBO bo = new PolicyBO();
            List<Policy> ps = new List<Policy>();
            Program.AgentPolicyList pDel = new AgentPolicyList(PolicyBO.ListPoliciesByAgent);
            ps = pDel(_policyList, agName);
            Console.WriteLine("Policy List");
            Console.WriteLine(String.Format("{0, -20}{1, -20}{2:#.00}", "PolicyId", "InsuranceType", "PremiumPayable"));
            foreach (Policy p in ps)
            {
                Console.WriteLine(String.Format("{0, -20}{1, -20}{2:#.00}", p.Id, p.InsuranceType.Type, p.PremiumPayable.ToString("f2")));
            }
            string tName = Console.ReadLine();
            Program.ListPoliciesByTypeDel tDel = new ListPoliciesByTypeDel(PolicyBO.ListPoliciesByType);
            List<Policy> ps2 = new List<Policy>();
            ps2 = tDel(_policyList, tName);
            Console.WriteLine("Policy List");
            Console.WriteLine(String.Format("{0, -20}{1, -20}{2:#.00}", "PolicyId", "Agent", "PremiumPayable"));
            foreach (Policy p in ps2)
            {
                Console.WriteLine(String.Format("{0, -20}{1, -20}{2:#.00}", p.Id, p.Agent.Name, p.PremiumPayable.ToString("f2")));
            }
        }
    }
    }
}
