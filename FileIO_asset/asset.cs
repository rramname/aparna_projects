using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO_asset
{
    public class Asset
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        private string _serialNumber;
        public string SerialNum
        {
            get { return _serialNumber; }
            set { _serialNumber = value; }
        }

        private DateTime _purchaseDate;
        public DateTime Pdate
        {
            get { return _purchaseDate; }
            set { _purchaseDate = value; }
        }

        private double _cost;
        public double Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

        public Asset(string _name, string _serialNumber, DateTime _purchaseDate, double _cost)
        {
            this._name = _name;
            this._serialNumber = _serialNumber;
            this._purchaseDate = _purchaseDate;
            this._cost = _cost;
        }

        public override string ToString()
        {
            return String.Format("{0,-15}{1,-15}{2,-15}{3,-15}", this._name, this._serialNumber, DateTime.Now.ToString("dd-MM-yyyy"), this._cost);
            
        }


    }
}
