using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_ExpensiveAsset
{
    public class Asset
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _category;
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        private double _cost;
        public double Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

        public Asset(string name, string category, double cost)
        {
            this._name = name;
            this._category = category;
            this._cost= cost;
        }

     
    }
}
