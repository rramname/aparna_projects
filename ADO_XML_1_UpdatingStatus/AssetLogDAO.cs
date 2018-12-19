using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ADO_XML_1_UpdatingStatus
{
    public class AssetLogDAO
    {
        public void UpdateAssetLog(int id, string pstatus)
        {

            using (SqlConnection sqlConnection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand("Update AssetLog  set status='" + pstatus + "' where asset_id = " + id, sqlConnection);

                sqlConnection.Open();
                command.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
        public List<AssetLog> GetAllAssetLogs()
        {
            List<AssetLog> assets = new List<AssetLog>();
            using (SqlConnection sqlConnection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT asset_id, username,expected_checkout_date,status FROM AssetLog order by asset_id asc;", sqlConnection);
                sqlConnection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {


                        AssetLog a = new AssetLog(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
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

        public List<string> GetAllAssetStatuses()
        {
            List<string> statuses = new List<string>();


            XmlDocument doc = new XmlDocument();
            doc.Load("input.xml");
            XmlNodeList lst = doc.DocumentElement.SelectNodes("/AssetLogDetails/AssetLog/Status");
            foreach (XmlNode n in lst)
            {
                statuses.Add(n.InnerText);
            }
            return statuses;
        }

        public string GetAllAssetStatusByID(int id)
        {
            string statuses = "";


            XmlDocument doc = new XmlDocument();
            doc.Load("input.xml");
            XmlNodeList lst = doc.DocumentElement.SelectNodes("/AssetLogDetails/AssetLog");
            foreach (XmlNode n in lst)
            {
                XmlNode id1 = n.SelectSingleNode("/Id");
                if (int.Parse(id1.InnerText) == id)
                {
                    statuses = n.SelectSingleNode("/Status").InnerText;
                }

            }
            return statuses;
        }
    }
}
