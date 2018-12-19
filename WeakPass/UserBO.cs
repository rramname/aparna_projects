using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WeakPass
{
    public class UserBO
    {
        public static ArrayList FindUsers(ArrayList userList)
        {
            List<UserDetail> list = new List<UserDetail>();
            
            foreach(UserDetail item in userList)
            {
                int len = item.Password.Length;
                bool match = Regex.IsMatch(item.Password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$");
                if (len < 6 || match == false)
                    list.Add(item);
            }

            return new ArrayList(list);
        }
    }
}
