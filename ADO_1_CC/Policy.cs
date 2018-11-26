using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_1_CC
{
    public class Policy
    {
        int _policyId;
        string _name;
        double _premium;

        public Policy(int _policyId, string _name, double _premium)
        {
            this._policyId = _policyId;
            this._name = _name;
            this._premium = _premium;
        }

        public int PolicyId
        {
            get
            {
                return _policyId;
            }

            set
            {
                this._policyId = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                this._name = value;
            }
        }
        public double Premium
        {
            get
            {
                return _premium;
            }

            set
            {
                this._premium = value;
            }
        }

    }
}
