using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_1_AssetStatus
{
    public class Asset_Status
    {
 

        private int _id;
        private string _status;

        public Asset_Status(int _id, string _status)
        {
            this._id = _id;
            this._status = _status;
    
        }
        public int Id { get { return _id; } set { _id = value; } }
        public string Status { get { return _status; } set { _status = value; } }

    }
}
