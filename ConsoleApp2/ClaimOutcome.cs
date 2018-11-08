using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class ClaimOutcome
    {
        private string _outcomeCode;
        public string OutcomeCode
        {
            get { return _outcomeCode; }
            set { _outcomeCode = value; }
        }

        private string _outcomeDescription;
        public string OutcomeDescription
        {
            get { return _outcomeDescription; }
            set { _outcomeDescription = value; }
        }
        public ClaimOutcome()
        {

        }
        public ClaimOutcome(string OutcomeCode, string OutcomeDescription)
        {
            this._outcomeCode = OutcomeCode;
            this._outcomeDescription = OutcomeDescription;

        }
    }
}
