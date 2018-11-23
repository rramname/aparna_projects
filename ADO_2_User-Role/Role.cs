using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_2_User_Role
{
    public class Role
    {
        int _roleId;
        string _name;

        public Role(int _roleId, string _name)
        {
            this._roleId = _roleId;
            this._name = _name;
        }

        public int RoleId
        {
            get
            {
                return _roleId;
            }

            set
            {
                this._roleId = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                this._name = value;
            }
        }
    }
}
