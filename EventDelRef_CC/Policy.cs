namespace EventDelRef_CC
{
    public class Policy
    {

        public Policy(int _id, InsuranceType inType, Agent a, double pre)
        {
            this._id = _id;
            this._insuranceType = inType;
            this._agent = a;
            this._premiumPayable = pre;

        }
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }



        private InsuranceType _insuranceType;
        public InsuranceType InsuranceType
        {
            get { return _insuranceType; }
            set { _insuranceType = value; }
        }



        private Agent _agent;
        public Agent Agent
        {
            get { return _agent; }
            set { _agent = value; }
        }


        private double _premiumPayable;
        public double PremiumPayable
        {
            get { return _premiumPayable; }
            set { _premiumPayable = value; }
        }
    }
}