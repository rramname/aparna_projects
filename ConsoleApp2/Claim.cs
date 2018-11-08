using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Claim
    {
        private string _claimID;
        public string ClaimID
        {
            get { return _claimID; }
            set { _claimID = value; }
        }

        private string _policyID;
        public string PolicyID
        {
            get { return _policyID; }
            set { _policyID = value; }
        }
        private ClaimOutcome _claimOutcome;
        public ClaimOutcome ClaimoutCome
        {
            get { return _claimOutcome; }
            set { _claimOutcome = value; }
        }
        private double _claimAmount;
        public double ClaimAmount
        {
            get { return _claimAmount; }
            set { _claimAmount = value; }
        }

        private string _status;
        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }
        public Claim(string ClaimID, string PolicyID, string OutcomeCode, string OutcomeDescription, double ClaimAmount, string Status="Open")
        {
            this._claimID = ClaimID;
            this._policyID = PolicyID;
            ClaimOutcome outc = new ClaimOutcome();
            outc.OutcomeCode = OutcomeCode;
            outc.OutcomeDescription = OutcomeDescription;
            this._claimOutcome = outc;
            this._claimAmount = ClaimAmount;
            this.Status = Status;
        }
        public override string ToString()
        {
            return  String.Format("{0,-20}{1,-20}{2,-20}{3,-20}{4,-20}{5,-20}", this._policyID, this._claimID, this._claimAmount.ToString(),this._status, this._claimOutcome.OutcomeCode, this._claimOutcome.OutcomeDescription);
        }
    }
}
