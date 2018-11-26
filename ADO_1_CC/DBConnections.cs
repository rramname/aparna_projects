using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ADO_1_CC
{
    public class DBConnection
    {
        public static SqlConnection GetConnection()
        {
            String xmlString = System.IO.File.ReadAllText("mssql.xml");

            string username;
            string password;
            string schema;
            string host;

            using (XmlReader reader = XmlReader.Create(new StringReader(xmlString)))
            {
                reader.ReadToFollowing("username");
                username = reader.ReadElementContentAsString();
                reader.ReadToFollowing("password");
                password = reader.ReadElementContentAsString();
                reader.ReadToFollowing("host");
                host = reader.ReadElementContentAsString();
                reader.ReadToFollowing("schema");
                schema = reader.ReadElementContentAsString();
            }


            string connection_string = "Data Source=" + host + ";Initial Catalog=" + schema + ";User id=" + username + ";Password=" + password + ";";
            SqlConnection conn = new SqlConnection(connection_string);
            return conn;

        }
    }
}
