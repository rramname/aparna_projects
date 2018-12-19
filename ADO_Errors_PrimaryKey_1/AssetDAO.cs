using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ADO_Errors_PrimaryKey_1
{
    public class AssetDAO
    {
        public List<Asset> GetAllAssetDetails()
        {
            List<Asset> assets = new List<Asset>();
            using (SqlConnection sqlConnection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT id, name,category,purchaseDate,cost FROM Asset;", sqlConnection);
                sqlConnection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // double Pcost = double.Parse(reader.GetString(4));  
                        Asset a = new Asset(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
                        assets.Add(a);
                    }
                }

            }

            return assets;

        }
        public int CreateAsset(Asset asset)
        {
            List<Asset> assets = new List<Asset>();
            int returnval = 0;
            try
            {
                using (SqlConnection sqlConnection = DBConnection.GetConnection())
                {
                    SqlCommand command = new SqlCommand("INSERT INTO asset (id, name,category, purchaseDate,cost)" +
                     "VALUES( @_id, @_name, @_category,@_purchaseDate,@_cost);", sqlConnection);

                    command.Parameters.Add("@_id", SqlDbType.Int);
                    command.Parameters["@_id"].Value = asset.Id;
                    //command.Parameters.AddWithValue("@_id", asset.Id);
                    command.Parameters.AddWithValue("@_name", asset.Name);
                    command.Parameters.AddWithValue("@_category", asset.Category);
                    command.Parameters.AddWithValue("@_purchaseDate", asset.purchaseDate);
                    command.Parameters.AddWithValue("@_cost", asset.Cost);
                    sqlConnection.Open();
                    command.ExecuteNonQuery();
                    sqlConnection.Close();
                    returnval = 1;

                }
            }
            catch (Exception e)
            {

                return 0;
            }

            return returnval;

        }
    }
}