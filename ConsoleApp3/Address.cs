using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Address
    {
        private string _street;
        public string Street
        {
            get { return _street; }
            set { _street = value; }
        }

        private string _city;
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        private string _country;
        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }

        private string _zipcode;
        public string Zipcode
        {
            get { return _zipcode; }
            set { _zipcode = value; }
        }

        public Address()
        {

        }

        public Address(string Street,string City,string Country, string Zip)
        {
            this._street = Street;
            this._city = City;
            this._country = Country;
            this.Zipcode = Zip;
        }

        public override string ToString()
        {
            // return String.Format("{0,-20}{1,-10}", Name, Address);
            return String.Format("{0,-20}{1,-20}{2,-10}{3}", Street, City, Country, Zipcode);
        }

    }
}
