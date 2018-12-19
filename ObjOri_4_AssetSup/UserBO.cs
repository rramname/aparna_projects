using System;

namespace ObjOri_4_AssetSup
{
    internal class UserBO
    {
        public void DisplayUserDetails(User[] user)
        {
            System.Console.WriteLine(String.Format("{0,-20}{1,0}", "User Name", "Employee Number"));
            foreach(User u in user)
            {
                System.Console.WriteLine(String.Format("{0,-20}{1,0}", u.UserName, u.EmployeeNo));
            }
        }

    }
}