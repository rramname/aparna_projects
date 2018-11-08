using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Policy
    {
        private string _policyName;
        public string PolicyName
        {
            get { return _policyName; }
            set { _policyName = value; }
        }

        private string _policyID;
        public string PolicyID
        {
            get { return _policyID; }
            set { _policyID = value; }
        }

        private double _premiumPayable;
        public double PremiumPayable
        {
            get { return _premiumPayable; }
            set { _premiumPayable = value; }
        }

        public Agent _agent;

        public Policy(string PolicyID, Agent _agent, string PolicyName="Life Insurance", double PremiumPayable = 3000)
        {
            this._policyName = PolicyName;
            this.PolicyID = PolicyID;
            this._premiumPayable = PremiumPayable;
            this._agent = _agent;
        }
        public override string ToString() {
            return String.Format("{0,-20}{1,-20}{2,-20}{3,-20}{4,-20}", this._agent.AgentID, this._agent.AgentName, this._policyID, this._policyName, this._premiumPayable.ToString());
        }

    }
}
