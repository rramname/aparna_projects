using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_XML_UnpaidAsset
{
    public class Asset
    {
        private string _serialNumber;
        private string _name;
        private string _category;
        private string _supplier;
        private string _cost;

        public string SerialNumber
        {
            get { return _serialNumber; }
            set { _serialNumber = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        public string Supplier
        {
            get { return _supplier; }
            set { _supplier = value; }
        }

        public string Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

        public Asset(string serialNumber, string name, string category, string supplier, string cost)
        {
            _serialNumber = serialNumber;
            _name = name;
            _category = category;
            _supplier = supplier;
            _cost = cost;
        }

        public override string ToString()
        {
            return String.Format("{0,-20}{1,-20}{2,-20}{3,-20}{4}", SerialNumber, Name, Category, Supplier, Cost);
        }
    }
}
