using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO_ProductOfSuppliers
{
    public class Model
    {
        private string _modelName;
        public string Mname
        {
            get { return _modelName; }
            set { _modelName = value; }
        }

        private string _manufacturer;
        public string Manufacturer
        {
            get { return _manufacturer; }
            set { _manufacturer = value; }
        }
    }
}
