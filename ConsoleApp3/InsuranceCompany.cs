using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class InsuranceCompany
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private Address _address;
        public Address Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public InsuranceCompany()
        {

        }
        public InsuranceCompany(string name, Address a)
        {
            this._name = Name;
            this._address = a;
        }

        public override string ToString()
        {
            return String.Format("{0,-20}{1,-10}", Name, Address);
            //return String.Format("{0,-20}{1,-20}{2,-10}{3}{3,-10}{4}",this.Name, this.Address.Street, this.Address.City, this.Address.Country, this.Address.Zipcode);
        }
    }
}
