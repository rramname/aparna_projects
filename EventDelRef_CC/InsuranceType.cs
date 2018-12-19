using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDelRef_CC
{
    public class InsuranceType
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _type;
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public InsuranceType(int id, string type)
        {
            this._id = id;
            this._type = type;
        }
    }
}
