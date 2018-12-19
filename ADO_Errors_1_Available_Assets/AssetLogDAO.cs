using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ADO_Errors_1_Available_Assets
{
    public class AssetLogDAO
    {
        public List<AssetLog> DisplayAllAssets()
        {
            List<AssetLog> assets = new List<AssetLog>();
            using (SqlConnection sqlConnection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT asset_id,user_checkout_to,expected_check_in,asset_status FROM assetlog;", sqlConnection);
                sqlConnection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        AssetLog log = new AssetLog(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                        assets.Add(log);
                        //statuses.Add(reader.GetInt32(0).ToString()+"."+reader.GetString(1));
                        //Asset_Status st = new Asset_Status(reader.GetInt32(0), reader.GetString(1));
                        //statuses.Add(st.Id.ToString() + "." + st.Status);


                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                reader.Close();
                return assets;
            }
        }

        public Asset DisplayAvailableAssets(int assetId)
        {
            Asset a = new Asset();

            using (SqlConnection sqlConnection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT l.asset_id,asset_name,category,asset_status FROM assetlog l join asset a on a.asset_id=l.asset_id where l.asset_id="+assetId, sqlConnection);
                sqlConnection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (reader.GetString(3).ToUpper() == "ASSIGNED")
                            throw new InvalidAccessException("Asset already assigned");

                        if (reader.GetString(3).ToUpper() == "UNDER_MAINTENANCE")
                            throw new InvalidAccessException("Asset under maintenance");

                        a = new Asset(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                        
                        //statuses.Add(reader.GetInt32(0).ToString()+"."+reader.GetString(1));
                        //Asset_Status st = new Asset_Status(reader.GetInt32(0), reader.GetString(1));
                        //statuses.Add(st.Id.ToString() + "." + st.Status);


                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                reader.Close();
                return a;
            }
        }
    }
}