using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDel_3_EmpDetails
{
    
    class Program
    {
        static void Main(string[] args)
        {
            UserBO bo = new UserBO();

            string[] str = Console.ReadLine().Split(',');


            User u = new User(str[0], str[1], str[2], str[3]);
            UserBO.PrintDetails de = null;
            de += bo.PrintEmployeeNumber;
            de += bo.PrintFirstName;
            de += bo.PrintLastName;
            de += bo.PrintEmail;

            de(u);
            Console.WriteLine("Employee details after email function is removed");
            de -= bo.PrintEmail;

            de(u);
        }
    }
}
