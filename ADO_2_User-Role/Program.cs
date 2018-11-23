using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_2_User_Role
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Format("{0, -15}{1, -30}{2, -15}{3}", "User", "Role", "Company", "Location"));

            UserBO b = new UserBO();
            List<User> users = new List<User>();
            users = b.GetAllUsers();

            foreach(User u in users)
            {
                Console.WriteLine(String.Format("{0, -15}{1, -30}{2, -15}{3}", u.Name, u.Role.Name, u.Company.Name, u.Company.Country));
            }
        }
    }
}
