using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_CC_Exceptions
{
    public class CalimDAO
    {
        public bool AddClaim(string column1, string column2, string column3, string column4, string value1, string value2, string value3, string value4)
        {
            try
            {
                using (SqlConnection sqlConnection = DBConnection.GetConnection())
                {
                    SqlCommand command = new SqlCommand("INSERT INTO claim(id, policy_type, claim_amount,claimed_date)" +
                     "VALUES(@_id1, @_policy_type1, @_claim_amount1,@_claimed_date1);", sqlConnection);

                    if (column1 != "id")
                        throw new InvalidColumn(column1);


                    if (column2 != "policy_type")
                        throw new InvalidColumn(column2);


                    if (column3 != "claim_amount")
                        throw new InvalidColumn(column3);


                    if (column4 != "claimed_date")
                        throw new InvalidColumn(column4);

                    //command.Parameters.AddWithValue("@_id", asset.Id);
                    //command.Parameters.AddWithValue("@_id", column1);
                    //command.Parameters.AddWithValue("@_policy_type", column2);
                    //command.Parameters.AddWithValue("@_claim_amount", column3);
                    //command.Parameters.AddWithValue("@_claimed_date", column4);

                    command.Parameters.AddWithValue("@_id1", value1);
                    command.Parameters.AddWithValue("@_policy_type1", value2);
                    command.Parameters.AddWithValue("@_claim_amount1", value3);
                    command.Parameters.AddWithValue("@_claimed_date1", value4);

                    // sqlConnection.Open();
                    command.ExecuteNonQuery();
                    sqlConnection.Close();


                }
            }
            catch (InvalidColumn e)
            {
                Console.WriteLine("Invalid column name '" + e.Message + "'.");
                return false;
            }
            return true;
        }
    }
}

