using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_1_AssetStatus
{
    public class AssetDAO
    {
        public List<Asset> GetAllAsset()
        {
            List<Asset> assets = new List<Asset>();
            using(SqlConnection sqlConnection =DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT id, name,username,status FROM Asset;", sqlConnection);
                sqlConnection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                       
                        
                        Asset a = new Asset(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                        assets.Add(a);
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                reader.Close();
            }
            return assets;
        }

        public List<string> GetAllAssetStatus()
        {
            List<string> statuses = new List<string>();
            List<Asset_Status> astts = new List<Asset_Status>();
            using (SqlConnection sqlConnection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT id, status FROM Asset_Status;", sqlConnection);
                sqlConnection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        //statuses.Add(reader.GetInt32(0).ToString()+"."+reader.GetString(1));
                        //Asset_Status st = new Asset_Status(reader.GetInt32(0), reader.GetString(1));
                        //statuses.Add(st.Id.ToString() + "." + st.Status);

                         statuses.Add(reader.GetString(1));
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                reader.Close();
            }
            return statuses;
        }

        public List<Asset_Status> GetAllAssetStatusByID()
        {
            
            List<Asset_Status> astts = new List<Asset_Status>();
            using (SqlConnection sqlConnection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT id, status FROM Asset_Status;", sqlConnection);
                sqlConnection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                       
                        Asset_Status st = new Asset_Status(reader.GetInt32(0), reader.GetString(1));

                        astts.Add(st);
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                reader.Close();
            }
            return astts;
        }

        public void UpdateAsset(int id, string status)
        {
            List<string> statuses = new List<string>();
            //int updateStatus = int.Parse(status);
            int statusId = GetAllAssetStatusByID().Where(x => x.Status == status).First().Id;
            using (SqlConnection sqlConnection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand("Update Asset  set status=(select top 1 status from Asset_status where id= " + statusId + ") from Asset where id="+id, sqlConnection);
                sqlConnection.Open();
                command.ExecuteNonQuery();
                sqlConnection.Close();
            }
         }

    }
}
