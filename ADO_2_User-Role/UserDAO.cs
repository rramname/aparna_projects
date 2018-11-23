using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_2_User_Role
{
    class UserDAO
    {
        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            using (SqlConnection sqlConnection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT distinct u.id,u.name,r.id,r.name,c.id,c.name,c.address,c.state,c.country FROM usertable u join role r on u.role_id=r.id join company c on u.company_id=c.id order by u.name;", sqlConnection);
                sqlConnection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Role r = new Role(reader.GetInt32(2), reader.GetString(3));
                        Company c = new Company(reader.GetInt32(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8));
                        User u = new User(reader.GetInt32(0), reader.GetString(1), r, c);
                        users.Add(u);
                    }
                }

                return users;
                //fill your code
            }
        }
    }
}
