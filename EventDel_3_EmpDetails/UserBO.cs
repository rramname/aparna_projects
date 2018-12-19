using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDel_3_EmpDetails
{
    public class UserBO
    {
        public delegate void PrintDetails(User s);
        public void PrintEmployeeNumber(User s)
        {
            Console.WriteLine("Employee Id : " + s.EmployeeNumber);
        }

        public void PrintFirstName(User s)
        {
            Console.WriteLine("First Name : " + s.FirstName);
        }

        public void PrintLastName(User s)
        {
            Console.WriteLine("Last Name : " + s.LastName);
        }

        public void PrintEmail(User s)
        {
            Console.WriteLine("Email : " + s.Email);
        }
    }
}
