using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Xml;

namespace ADO_XML_UnpaidAsset
{
    internal class AssetDAO
    {
       

        public void RemovePaidAssets(string supplierName)
        {

            using (SqlConnection sqlConnection = DBConnection.GetConnection())
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("Delete from  Assset where name = '" + supplierName + "'", sqlConnection);


                command.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
        public List<Asset> GetAssets()
        {
            List<Asset> assets = new List<Asset>();
            using (SqlConnection sqlConnection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT serial_number,name,category,supplier,cost FROM Asset order by serial_number asc;", sqlConnection);
               // sqlConnection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {


                        Asset a = new Asset(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
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

        public List<string> GetSupplierNames(string xmlFileName1)
        {
            List<string> statuses = new List<string>();


            XmlDocument doc = new XmlDocument();
            doc.Load(xmlFileName1);
            XmlNodeList lst = doc.DocumentElement.SelectNodes("/SupplierDetails/Supplier/name");
            foreach (XmlNode n in lst)
            {
                statuses.Add(n.InnerText);
            }
            return statuses;
        }
    }
}