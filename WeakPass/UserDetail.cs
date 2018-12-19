using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeakPass
{
    public class UserDetail
    {
        private string name;

        private string email;

        private string userName;

        private string password;
 

        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }

        public override string ToString()
        {
            return String.Format("{0,-10}{1,-20}{2,-10}{3}", name, email, userName, password);
        }


        public UserDetail(string name, string email, string uname, string pass="changeMe")
        {
            this.name = name;
            this.email = email;
            this.userName = uname;
            this.password = pass;
        }
    }
}
