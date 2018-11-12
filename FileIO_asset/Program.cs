using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO_asset
{
    class Program
    {
        static void Main(string[] args)
        {
            string csvData = File.ReadAllText("input.csv");
            string[] rows = csvData.Split('\n');
            List<Asset> asset = new List<Asset>();
            foreach (string row in rows)
            {


                if (!string.IsNullOrEmpty(row))
                {
                    string[] cols = row.Split(',');
                    
                    string Name = cols[0];
                    string SerialNum = cols[1];
                    DateTime Pdate = DateTime.Parse(cols[2], new CultureInfo("en-CA"));// Convert.ToDateTime( cols[2]);
                    double Cost=Convert.ToDouble(cols[3]);
                    Asset c = new Asset(Name,SerialNum,Pdate,Cost);
                    asset.Add(c);
                }

            }
            Console.WriteLine(String.Format("{0,-15}{1,-15}{2,-15}{3,-15}", "Name", "Serial Number", "Purchase Date", "Purchase Cost"));
            foreach (Asset a in asset)
            {
                Asset _asset = new Asset(a.Name, a.SerialNum, a.Pdate, a.Cost);
                Console.WriteLine(_asset.ToString());
            }

            Console.ReadLine();
        }
    }
}
