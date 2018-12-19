using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    interface IRole
    {
        void CreateRole(Role role, List<Privilege> privilegeList);
        List<Privilege> GetPrivileges(string name);
    }
}
