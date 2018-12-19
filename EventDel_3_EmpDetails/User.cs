using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDel_3_EmpDetails
{
    public class User
    {

        public User(string _employeeNumber, string _firstName,string _lastName,string _email)
        {
            this._employeeNumber = _employeeNumber;
            this._firstName = _firstName;
            this._lastName = _lastName;
            this._email = _email;
        }
        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private string _employeeNumber;
        public string EmployeeNumber
        {
            get { return _employeeNumber; }
            set { _employeeNumber = value; }
        }
    }
}
