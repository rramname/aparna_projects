using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO_ProdSetup
{
    public class Asset
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        private string _serial;
        public string SerialNum
        {
            get { return _serial; }
            set { _serial = value; }
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
            this._serial = _serialNumber;
            this._purchaseDate = _purchaseDate;
            this._cost = _cost;
        }

   
    }
}
