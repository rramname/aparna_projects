using FileIO_ProdSetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO_ProdSupp
{
    class Supplier:IComparable
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _address;
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public List<Asset> _assetList;

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Supplier otherSupp = obj as Supplier;
            if (otherSupp != null)
                return this._name.CompareTo(otherSupp._name);
            else
                throw new ArgumentException("Object is not a Supplier");
        }
    }
}
