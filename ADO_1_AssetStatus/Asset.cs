using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_1_AssetStatus
{
    public class Asset
    {
        private int _id;
        private string _name;
        private string _username;
        private string _status;

        public Asset(int _id, string _name, string _username, string _status)
        {
            this._id = _id;
            this._name = _name;
            this._username = _username;
            this._status = _status;
        }
        public int Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string UserName { get { return _username; } set { _username = value; } }
        public string Status { get { return _status; } set { _status = value; } }
    }
}
