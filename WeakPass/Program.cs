using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeakPass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of users");
            int n = int.Parse(Console.ReadLine());
            ArrayList users = new ArrayList();
            
            for(int i = 0; i < n; i++)
            {
                string[] str = Console.ReadLine().Split(',');
                string name = str[0];
                string email = str[1];
                string uname = str[2];
                string pass = null;
                if (str.Length > 3)
                {
                    pass = str[3];
                    UserDetail u = new UserDetail(name, email, uname, pass);
                    users.Add(u);
                }
                else
                {
                    UserDetail u = new UserDetail(name, email, uname);
                    users.Add(u);
                }
                    



              
            }
            ArrayList fUsers = UserBO.FindUsers(users);
            if (fUsers.Count > 0)
            {
               Console.WriteLine(String.Format("{0,-10}{1,-20}{2,-10}{3}", "Name", "Email", "Username", "Password"));

                foreach (UserDetail u in fUsers)
                {
                    Console.WriteLine(u.ToString());
                }
            }
            else
                Console.WriteLine("No user with weak password");
            
        }
    }
}
