using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_1_CC
{
    class PolicyDAO
    {
        public List<Policy> FindMaxPremium()
        {
            List<Policy> policies = new List<Policy>();
            using (SqlConnection sqlConnection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT id, name,premium FROM policy where premium=(select max(premium) from policy);", sqlConnection);
                sqlConnection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Policy p = new Policy(reader.GetInt32(0), reader.GetString(1),reader.GetDouble(2));

                        policies.Add(p);
                    }
                }
            }
                return policies;
        }
    }
}
