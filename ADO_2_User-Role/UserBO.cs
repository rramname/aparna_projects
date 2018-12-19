using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_2_User_Role
{
    public class UserBO
    {
        public List<User> GetAllUsers()
        {
            UserDAO d = new UserDAO();
            return d.GetAllUsers();
            //fill your code
        }
    }
}
